using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFormManager : MonoBehaviour
{
    public IInteractable Interactable;

    private FormData form;

    public bool HasForm {
        get { return form != null; }
    }

    public void AddForm(GameObject formObj)
    {
        formObj.transform.SetParent(this.transform);
        form = formObj.GetComponent<FormData>();
    }

    public void Interact()
    {
        if (Interactable != null)
        {
            
        }
    }
}
