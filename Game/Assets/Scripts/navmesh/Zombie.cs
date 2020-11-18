using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Zombie : MonoBehaviour
{
    public Transform victim;
    public NavMeshAgent navComponent;
    // Start is called before the first frame update
    void Start()
    {
        navComponent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (victim)
        {
            navComponent.SetDestination(victim.position);
        }
    }
}
