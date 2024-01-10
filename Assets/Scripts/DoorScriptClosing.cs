using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class DoorScriptClosing : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;

    private void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter()
    {

        Debug.Log("Im inside");

        if (animator)
        {
            animator.enabled = true;
            animator.Play("Door Closing");
        }
            

        if (audioSource)
            audioSource.Play();
    }
}

