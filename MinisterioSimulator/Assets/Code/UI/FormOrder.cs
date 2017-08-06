using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FormOrder : MonoBehaviour
{
    [HideInInspector] public FormColor FormColor;
    [HideInInspector] public Attachment[] Attachments;

    public Image RedSeal;
    public Image GreenSeal;
    public Image BlueSeal;
    public Image Copies;

    public void DisplayForm(Order order)
    {
        FormColor = order.FormColor;
        Attachments = order.Attachments;

        this.GetComponent<Image>().color = GlobalReferences.resources.GetComponent<FormResources>().GetForm(FormColor).GetComponent<SpriteRenderer>().color;

        if (Attachments.Contains(Attachment.blueSeal))
        {
            BlueSeal.enabled = true;
        }

        if (Attachments.Contains(Attachment.greenSeal))
        {
            GreenSeal.enabled = true;
        }

        if (Attachments.Contains(Attachment.redSeal))
        {
            RedSeal.enabled = true;
        }

        if (Attachments.Contains(Attachment.duplicateCopy))
        {
            Copies.enabled = true;
        }
    }
}
