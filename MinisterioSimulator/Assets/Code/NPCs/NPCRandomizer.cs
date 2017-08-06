using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomizer : MonoBehaviour
{
    public SpriteRenderer Head;
    public SpriteRenderer Body;

    private float originalXRot;

    private void Start()
    {
        originalXRot = this.transform.eulerAngles.x;
        Head.sprite= GlobalReferences.resources.GetComponent<NpcsResources>().GetRandomHead();
        Body.sprite = GlobalReferences.resources.GetComponent<NpcsResources>().GetRandomBody();
    }

    private void Update()
    {
        this.transform.eulerAngles = new Vector3(originalXRot, 0f, 0f);
    }
}
