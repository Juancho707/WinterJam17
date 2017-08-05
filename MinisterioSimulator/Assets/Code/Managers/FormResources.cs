using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FormResources : MonoBehaviour
{
    public ColorFormResource[] FormsResource;

    public GameObject GetForm(FormColor col)
    {
        return FormsResource.First(x => x.FormType == col).FormPrefab;
    }
}
