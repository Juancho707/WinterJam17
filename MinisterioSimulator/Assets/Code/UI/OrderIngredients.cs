using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OrderIngredients : MonoBehaviour
{
    public GameObject RedSealUIPrefab;
    public GameObject CopiesUIPrefab;
    public GameObject GreenSealUIPrefab;
    public GameObject BlueSealUIPrefab;
    public GameObject FormIngredUIPrefab;

    public void DisplayIngredients(Order order)
    {
        var formIngred = Instantiate(FormIngredUIPrefab, this.transform).GetComponent<Image>();
        formIngred.color = GlobalReferences.resources.GetComponent<FormResources>().GetForm(order.FormColor).GetComponent<SpriteRenderer>().color;

        if (order.Attachments.Contains(Attachment.blueSeal))
        {
            Instantiate(BlueSealUIPrefab, this.transform);
        }

        if (order.Attachments.Contains(Attachment.greenSeal))
        {
            Instantiate(GreenSealUIPrefab, this.transform);
        }

        if (order.Attachments.Contains(Attachment.redSeal))
        {
            Instantiate(RedSealUIPrefab, this.transform);
        }

        if (order.Attachments.Contains(Attachment.duplicateCopy))
        {
            Instantiate(CopiesUIPrefab, this.transform);
        }
    }
}
