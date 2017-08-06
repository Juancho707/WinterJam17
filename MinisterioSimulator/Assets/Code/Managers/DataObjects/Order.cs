using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Order
{
    public FormColor FormColor;
    public Attachment[] Attachments;
    public float TimeLimit;

    private const float timeFactor = 7f;
    private const float baseTime = 10f;

    public Order()
    {
        this.FormColor = (FormColor)Random.Range(0, Enum.GetValues(typeof(FormColor)).Length);

        var allAttachments = Enum.GetValues(typeof(Attachment)) as Attachment[];
        var availableAtt = allAttachments.ToList();

        var attachmentCount = Random.Range(0, Enum.GetValues(typeof(Attachment)).Length + 1);
        var requiredAttachments = new List<Attachment>();
        while (attachmentCount > 0)
        {
            var attch = availableAtt.PickOne();
            requiredAttachments.Add(attch);
            availableAtt.Remove(attch);
            attachmentCount--;
        }

        Attachments = requiredAttachments.ToArray();
        TimeLimit = baseTime + (timeFactor * Attachments.Length);
    }
}
