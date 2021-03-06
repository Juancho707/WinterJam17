﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOscillate : MonoBehaviour
{
    public float OscillatorFactor;
    public float OscillatorFrequency;
    public Axis axis;
    public bool AwakeOscillating;

    private bool isOscillating;
    private float angle;
    private RectTransform rect;

    private void Start()
    {
        rect = this.GetComponent<RectTransform>();
        if (AwakeOscillating)
        {
            StartOscillating();
        }
    }

    // Update is called once per frame
	void Update ()
	{
	    var oscillation = Vector3.zero;

	    switch (axis)
	    {
	        case Axis.X:
	            oscillation.x = OscillatorFactor * Mathf.Sin(angle);
	            break;
	        case Axis.Y:
	            oscillation.y = OscillatorFactor * Mathf.Sin(angle);
	            break;
	        case Axis.Z:
	            oscillation.z = OscillatorFactor * Mathf.Sin(angle);
	            break;
	    }

	    if (isOscillating)
	    {
            rect.Translate(oscillation);
	        this.angle += OscillatorFrequency;
	    }
	}

    public void StopOscillating()
    {
        if (isOscillating)
        {
            isOscillating = false;
        }
    }

    public void StartOscillating()
    {
        if (!isOscillating)
        {
            isOscillating = true;
        }
    }
}
