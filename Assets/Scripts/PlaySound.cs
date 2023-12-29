using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void RequestPlaySound()
    {
        audioSource.Play();
    }
}
