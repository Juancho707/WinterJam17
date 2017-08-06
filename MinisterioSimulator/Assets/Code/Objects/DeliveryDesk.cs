using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeliveryDesk : MonoBehaviour, IInteractable
{
    public string TooltipTxt;
    public OrderInflow OrderBar;

    public string DisplayName
    {
        get { return "delivery"; }
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
            CheckForm(pManager.GetForm);
            pManager.DestroyForm();
        }
    }

    private void CheckForm(FormData inputForm)
    {
        var orders = OrderBar.GetComponentsInChildren<OrderUI>();
        var isVerified = false;
        var index = 0;

        while (!isVerified & index < orders.Length)
        {
            isVerified = CompareOrder(inputForm, orders[index].OrderData);
            if (isVerified)
            {
                Destroy(orders[index].gameObject);
                this.GetComponent<AudioSource>().Play();
                GlobalReferences.score.AddSuccess();
            }
            else
            {
                GlobalReferences.audioPlayer.PlayError();
            }

            index++;
        }
    }

    private bool CompareOrder(FormData inputForm, Order order)
    {
        if (order.FormColor != inputForm.Color)
        {
            return false;
        }

        if (order.Attachments.Length != inputForm.Attachments.Count)
        {
            return false;
        }

        foreach (var a in inputForm.Attachments)
        {
            if (!order.Attachments.Contains(a))
            {
                return false;
            }
        }

        return true;
    }
}
