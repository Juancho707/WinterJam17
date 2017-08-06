using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipManager : MonoBehaviour
{
    public Tooltip tooltip;

    private IInteractable interactable;

    private void Start()
    {
        interactable = GetComponentInParent<IInteractable>();
        var originalXRot = tooltip.transform.eulerAngles.x;
        tooltip.transform.eulerAngles = new Vector3(originalXRot, 0f, 0f);
    }

    public void Show()
    {
        tooltip.gameObject.SetActive(true);
        tooltip.UpdateDisplay(interactable.TooltipMsg, ControlButtons.buttonA);
    }

    public void Hide()
    {
        tooltip.gameObject.SetActive(false);
    }
}
