using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ExtensionMethods
{
    public static T PickOne<T>(this IEnumerable<T> col)
    {
        var rnd = Random.Range(0, col.Count());
        return col.ToArray()[rnd];
    }
}
