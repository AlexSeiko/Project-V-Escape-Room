using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ActivateCinemateca : MonoBehaviour
{
    [SerializeField] private GameObject CinematecaComponent;
    [SerializeField] private GameObject ExitecaComponent;

    void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;

        CinematecaComponent?.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the CinematecaComponent is not null before deactivating
        if (CinematecaComponent != null)
        {
            CinematecaComponent.SetActive(true);
        }

        if (ExitecaComponent != null)
        {
            ExitecaComponent.SetActive(false);
        }
    }
}
