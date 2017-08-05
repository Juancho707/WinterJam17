using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour {

    private NavMeshAgent agent;
    private int playerId;
    private PlayerMetadata meta;
    private PlayerFormManager formmMngr;

    public float Speed;

	// Use this for initialization
	void Start ()
	{
        formmMngr = this.GetComponent<PlayerFormManager>();
        meta = this.GetComponent<PlayerMetadata>();
        agent = this.GetComponent<NavMeshAgent>();	
	}
	
	void FixedUpdate ()
    {
        Move();

        if (Input.GetButtonDown(string.Format("Interact_P{0}", meta.PlayerId)))
        {
            formmMngr.Interact();
        }
    }

    void Move()
    {
        var horizValue = Input.GetAxis(string.Format("Horizontal_P{0}", meta.PlayerId));
        var vertValue = Input.GetAxis(string.Format("Vertical_P{0}", meta.PlayerId));
        var moveVector = Vector3.zero;

        if (horizValue != 0)
        {
            moveVector.x = horizValue * Speed;
        }

        if (vertValue != 0)
        {
            moveVector.z = vertValue * Speed;
        }

        agent.Move(moveVector);
    }
}
