using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Interactable"))
        {
            //Display Desk Action
            Debug.Log("ShowTooltip");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Interactable"))
        {
            //Hide Desk Action
            Debug.Log("HideTooltip");
        }
    }
}
