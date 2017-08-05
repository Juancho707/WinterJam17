using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDetector : MonoBehaviour
{
    private PlayerMetadata myPlayer;
    private PlayerFormManager myPlayerMgr;

    private void Start()
    {
        myPlayer = this.GetComponent<PlayerMetadata>();
        myPlayerMgr = this.GetComponent<PlayerFormManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Interactable"))
        {
            myPlayerMgr.Interactable = other.GetComponent<IInteractable>();
            Debug.Log(string.Format("Player {0} entered zone of {1}",myPlayer.PlayerId, other.GetComponentInParent<IInteractable>().DisplayName));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Interactable"))
        {
            myPlayerMgr.Interactable = null;
            Debug.Log(string.Format("Player {0} exited zone of {1}", myPlayer.PlayerId, other.GetComponentInParent<IInteractable>().DisplayName));
        }
    }
}
