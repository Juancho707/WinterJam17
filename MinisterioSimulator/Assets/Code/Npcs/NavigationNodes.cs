using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;

public class NavigationNodes : MonoBehaviour
{
    private Transform[] Nodes;

    private void Start()
    {
        Nodes = this.GetComponentsInChildren<Transform>().Where(x => x.tag.Equals("NavNode")).ToArray();
    }

    public Transform GetRandomNode()
    {
        return Nodes.PickOne();
    }
}
