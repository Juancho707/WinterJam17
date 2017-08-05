using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Boo.Lang.Runtime.DynamicDispatching;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public Transform TargetAnchor;
    public float factor;

    private void Update()
    {
        var target = Vector3.Lerp(Vector3.zero, TargetAnchor.position, factor);

        this.transform.LookAt(target);
    }
}
