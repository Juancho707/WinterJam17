using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentDesk : MonoBehaviour, IInteractable
{
    public Attachment AttachmentType;
    public string TooltipTxt;

    public string DisplayName
    {
        get { return AttachmentType.ToString(); }
    }

    public string TooltipMsg
    {
        get { return TooltipTxt; }
    }

    public void Interact(GameObject player)
    {
        var pManager = player.GetComponent<PlayerFormManager>();
        if (pManager.HasForm)
        {
            pManager.AddAttachment(AttachmentType);
            if (AttachmentType != Attachment.duplicateCopy)
            {
                GlobalReferences.audioPlayer.PlayRandomStamp();
            }
        }

        var printerAnim = this.GetComponentInChildren<PrinterMachine>();
        if (printerAnim != null)
        {
            printerAnim.PlayPrintAnimation();
            this.GetComponent<AudioSource>().Play();
        }
    }
}
