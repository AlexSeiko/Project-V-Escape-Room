using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ActivateEndgame : MonoBehaviour
{
    [SerializeField] private GameObject TeleporterShow;


    void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;

        TeleporterShow?.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the CinematecaComponent is not null before deactivating
        if (TeleporterShow != null)
        {
            TeleporterShow.SetActive(true);
        }
    }
}
