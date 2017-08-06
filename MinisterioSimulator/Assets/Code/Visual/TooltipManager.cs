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
