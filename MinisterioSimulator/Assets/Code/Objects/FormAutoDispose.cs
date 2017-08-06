using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Persistence;

public class FormAutoDispose : MonoBehaviour, IInteractable
{
    public float MaxLifetime;
    private float elapsedLife;
    private bool isDropped;

    public string DisplayName
    {
        get { return "form"; }
    }

    public void Drop()
    {
        isDropped = true;
    }

    public void Interact(GameObject player)
    {
        isDropped = false;
        elapsedLife = 0;
    }
    
    private void FixedUpdate()
    {
        if (isDropped)
        {
            elapsedLife += Time.fixedDeltaTime;
            if (elapsedLife > MaxLifetime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
