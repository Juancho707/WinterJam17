using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AudioResources : MonoBehaviour
{
    public AudioClip[] Insults;
    public AudioClip[] Stamps;
    public AudioClip Error;

    public float InsultVolume;
    public float StampVolume;

    private AudioSource source;

    private void Start()
    {
        source = this.GetComponent<AudioSource>();
    }

    public AudioClip GetRandomStamp()
    {
        return Stamps.PickOne();
    }

    public AudioClip GetRandomInsult()
    {
        return Insults.PickOne();
    }

    public void PlayRandomInsult()
    {
        source.clip = GetRandomInsult();
        source.volume = InsultVolume;
        source.Play();
    }

    public void PlayRandomStamp()
    {
        source.clip = GetRandomStamp();
        source.volume = StampVolume;
        source.Play();
    }

    public void PlayError()
    {
        source.clip = Error;
        source.volume = InsultVolume;
        source.Play();
    }
}
