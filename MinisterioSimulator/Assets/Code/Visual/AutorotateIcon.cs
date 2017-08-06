using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutorotateIcon : MonoBehaviour
{

    private void Start()
    {
        var originalXRot = this.transform.eulerAngles.x;
        this.transform.eulerAngles = new Vector3(originalXRot, 0f, 0f);
    }

}
