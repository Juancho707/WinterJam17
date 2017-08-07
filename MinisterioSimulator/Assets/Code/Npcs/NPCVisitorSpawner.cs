using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCVisitorSpawner : MonoBehaviour
{
    public Transform Spawn;
    public Transform GoTo;
    public GameObject VisitorPrefab;
    public float SpawnFrequency;
    public float DeSpawnFrequency;

    private float spawnElapsed;
    private float despawnElapsed;

    private void FixedUpdate()
    {
        spawnElapsed += Time.fixedDeltaTime;
        despawnElapsed += Time.fixedDeltaTime;

        if (spawnElapsed > SpawnFrequency)
        {
            spawnElapsed = 0;
            var visitor = Instantiate(VisitorPrefab, Spawn).GetComponent<VisitorNav>();
            visitor.GoTo(GoTo.position);
        }

        if (despawnElapsed > despawnElapsed)
        {
            despawnElapsed = 0;
            Destroy(GameObject.Find("VisitorNPC (Clone)"));
        }
    }
}
