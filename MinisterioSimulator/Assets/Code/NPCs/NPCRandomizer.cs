using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomizer : MonoBehaviour
{
    public SpriteRenderer Head;
    public SpriteRenderer Body;

    private void Start()
    {
        Head.sprite= GlobalReferences.resources.GetComponent<NpcsResources>().GetRandomHead();
        Body.sprite = GlobalReferences.resources.GetComponent<NpcsResources>().GetRandomBody();
    }
}
