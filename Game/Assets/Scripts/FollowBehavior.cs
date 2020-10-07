using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            new Vector3(player.position.x, transform.position.y, player.position.z)
            , speed * Time.deltaTime
            );
    }
}
