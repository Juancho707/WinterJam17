using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {

    private NavMeshAgent agent;
    public int PlayerId;

    public float Speed;

	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        var horizValue = Input.GetAxis(string.Format("Horizontal_P{0}", PlayerId));
        var vertValue = Input.GetAxis(string.Format("Vertical_P{0}", PlayerId));
        var moveVector = Vector3.zero;

        if (horizValue != 0 )
        {
            moveVector.x =horizValue*Speed;
        }

        if (vertValue != 0)
        {
            moveVector.z = vertValue * Speed;
        }

        agent.Move(moveVector);
    }
}
