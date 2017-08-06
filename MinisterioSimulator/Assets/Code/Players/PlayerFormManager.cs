using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFormManager : MonoBehaviour
{
    public IInteractable Interactable;
    public Vector3 FormOffset;

    public FormData GetForm
    {
        get { return form; }
    }

    private FormData form;

    public bool HasForm {
        get { return form != null; }
    }

    public void AddForm(GameObject formObj)
    {
        formObj.transform.SetParent(this.transform);
        form = formObj.GetComponent<FormData>();
        formObj.transform.position = this.transform.position + FormOffset;
    }

    public void AddAttachment(Attachment attObj)
    {
        form.AddAttachment(attObj);
    }

    public void Interact()
    {
        if (Interactable != null)
        {
            if (HasForm)
            {
                var desk = Interactable as AttachmentDesk;
                if (desk != null)
                {
                    desk.Interact(this.gameObject);
                }
                else
                {
                    var desk1 = Interactable as DeliveryDesk;
                    if (desk1 != null)
                    {
                        desk1.Interact(this.gameObject);
                    }
                }
            }
            else
            {
                var desk = Interactable as FormDesk;
                if (desk != null)
                {
                    desk.Interact(this.gameObject);
                }
                else
                {
                    var droppedForm = Interactable as FormAutoDispose;
                    if (droppedForm != null)
                    {
                        droppedForm.Interact(this.gameObject);
                        droppedForm.transform.SetParent(this.transform);
                        droppedForm.transform.position = this.transform.position + FormOffset;
                        this.form = droppedForm.GetComponent<FormData>();
                    }
                }
            }
        }
    }

    public void Drop()
    {
        if (HasForm)
        {
            this.form.transform.parent = null;
            this.form.transform.position = this.transform.position + Vector3.up;
            this.form.GetComponent<FormAutoDispose>().Drop();
            this.form = null;
        }
    }

    public void DestroyForm()
    {
        Destroy(form.gameObject);
    }
}
