using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKey : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;

    private void Start()
    {
        if (animator)
        {
            animator.enabled = true;
            animator.Play("Key Rotation");
        }


        if (audioSource)
            audioSource.Play();
    }
}

