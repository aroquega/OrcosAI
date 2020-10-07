using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private Vector3 velocity = Vector3.zero;
    private Vector3 acceleration = Vector3.zero;
    [SerializeField]
    private float maxSpeed = 10.0f;
    [SerializeField]
    private float maxForce = 10.0f;
    [SerializeField]
    float radius = 10;

    // Update is called once per frame
    void Update()
    {
        Seek(target.position);
        velocity += acceleration * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;
        acceleration *= 0;
    }

    void ApplyForce(Vector3 force)
    {
        acceleration += force;
    }

    void Seek(Vector3 target)
    {
        Vector3 desired = target - transform.position;
        
        float distance = desired.magnitude;
        desired = desired.normalized;

        if (distance < radius){
            desired *= (distance * maxSpeed / radius);
        }
        else {
            desired *= maxSpeed;
        }
        
        Vector3 steering = desired - velocity;
        steering = Vector3.ClampMagnitude(steering, maxForce);
        ApplyForce(steering);
    }
}
