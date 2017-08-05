using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    public float OscillatorFactor;
    public float OscillatorFrequency;
    public Axis axis;

    private float angle;
	
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

	    this.transform.Translate(oscillation);
	    this.angle += OscillatorFrequency;
    }
}
