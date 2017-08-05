using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormDesk : MonoBehaviour, IInteractable
{
    public FormColor FormType;

    public string DisplayName
    {
        get { return FormType.ToString(); }
    }

    public void Interact(GameObject player)
    {
        var pManager = player.GetComponent<PlayerFormManager>();
        if (!pManager.HasForm)
        {
            pManager.AddForm(Instantiate(GlobalReferences.resources.GetComponent<FormResources>()
                .GetForm(FormType)));
        }
    }
}
