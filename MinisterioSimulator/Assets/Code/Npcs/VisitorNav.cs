using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VisitorNav : MonoBehaviour
{
    public float MaxStopDistance;
    public float MinStopDistance;

    private float StopDistance;
    public Oscillate[] Legs;
    private NavMeshAgent agent;
    
    private void Start()
    {
        StopDistance = UnityEngine.Random.Range(MinStopDistance, MaxStopDistance);
        agent = this.GetComponent<NavMeshAgent>();
    }

    public void GoTo(Vector3 target)
    {
        if (agent == null)
        {
            agent = this.GetComponent<NavMeshAgent>();
        }

        agent.SetDestination(target);
    }

    private void FixedUpdate()
    {
        if (agent.speed > 0)
        {
            foreach (var leg in Legs)
            {
                leg.StopOscillating();
            }
        }
        else
        {
            foreach (var leg in Legs)
            {
                leg.StartOscillating();
            }
        }
    }
}
