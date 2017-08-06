using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShreddingMachineDesk : MonoBehaviour, IInteractable
{
    public string TooltipTxt;

    private AudioSource audio;

    private void Start()
    {
        audio = this.GetComponent<AudioSource>();
    }

    public string DisplayName
    {
        get { return "shredder"; }
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
            pManager.DestroyForm();
        }

        var shredAnim = this.GetComponentInChildren<ShredderMachine>();
        if (shredAnim != null)
        {
            shredAnim.PlayShredAnimation();
            audio.Play();
        }
    }
}
