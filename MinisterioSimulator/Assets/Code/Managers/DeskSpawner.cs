using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeskSpawner : MonoBehaviour
{
    private void Start()
    {
        var spawners = this.GetComponentsInChildren<Transform>().Where(x => x.tag.Equals("Spawner")).ToList();
        var availableDesks = GlobalReferences.resources.GetComponent<DeskResources>().Desks;

        foreach (var d in availableDesks)
        {
            var spwn = spawners.PickOne();
            Instantiate(d,spwn.position, spwn.rotation);
            spawners.Remove(spwn);
        }
    }
}
