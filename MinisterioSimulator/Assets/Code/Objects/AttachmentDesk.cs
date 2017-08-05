using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentDesk : MonoBehaviour, IInteractable
{
    public Attachment AttachmentType;

    public void Interact(GameObject player)
    {
        var pManager = player.GetComponent<PlayerFormManager>();
        if (!pManager.HasForm)
        {
            pManager.AddAttachment(AttachmentType);
        }
    }
}
