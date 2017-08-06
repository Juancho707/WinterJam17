using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavigation : MonoBehaviour
{
    public float IdleTimeMax;
    public float IdleTimeMin;
    public float StopDistance;
    public Oscillate[] Legs;

    private float idleTime;
    private float idleElapsed;
    private NavMeshAgent agent;
    private Transform target;
    private bool isIdle;
    
    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        RegenIdleTime();
        isIdle = true;
    }

    private void StartMoving()
    {
        isIdle = false;
        GetNewNode();
        agent.destination = target.position;
    }

    private void GetNewNode()
    {
        target = GlobalReferences.navigation.GetRandomNode();
    }

    private void FixedUpdate()
    {
        if (isIdle)
        {
            idleElapsed += Time.fixedDeltaTime;
            if (idleElapsed > idleTime)
            {
                StartMoving();
            }

            foreach (var leg in Legs)
            {
                leg.StopOscillating();
            }
        }
        else
        {
            if (Vector3.Distance(target.position, this.transform.position) < StopDistance)
            {
                isIdle = true;
                RegenIdleTime();
                foreach (var leg in Legs)
                {
                    leg.StartOscillating();
                }
            }
        }
    }

    private void RegenIdleTime()
    {
        idleTime = UnityEngine.Random.Range(IdleTimeMin, IdleTimeMax);
    }
}
