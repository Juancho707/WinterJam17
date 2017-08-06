using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormData : MonoBehaviour
{
    public FormColor Color;
    public List<Attachment> Attachments;
    
    private void Start()
    {
        Attachments = new List<Attachment>();
    }

    public void AddAttachment (Attachment att)
    {
        if(!Attachments.Contains(att))
        {
            Instantiate(GlobalReferences.resources.GetComponent<AttachmentResources>().GetAttachment(att), this.transform);
            Attachments.Add(att);
        }
    }
}
