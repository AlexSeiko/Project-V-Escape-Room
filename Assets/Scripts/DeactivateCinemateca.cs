using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class DeactivateCinemateca : MonoBehaviour
{
    [SerializeField] private GameObject CinematecaComponent;
    [SerializeField] private GameObject ExitecaComponent;
    [SerializeField] private GameObject TeleporterShow;
    [SerializeField] private GameObject TeleporterHide;

    void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;

        ExitecaComponent?.SetActive(false);
        TeleporterShow?.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the CinematecaComponent is not null before deactivating
        if (CinematecaComponent != null)
        {
            CinematecaComponent.SetActive(false);
        }

        if (ExitecaComponent != null)
        {
            ExitecaComponent.SetActive(true);
        }

        if (TeleporterShow != null)
        {
            TeleporterShow.SetActive(true);
        }

        if (TeleporterHide != null)
        {
            TeleporterHide.SetActive(false);
        }
    }
}
