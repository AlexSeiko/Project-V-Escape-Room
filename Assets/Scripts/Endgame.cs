using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Endgame : MonoBehaviour
{
    [SerializeField] private GameObject TeleporterShow;
    [SerializeField] private GameObject TeleporterHide;

    void Start()
    {
        GetComponent<SphereCollider>().isTrigger = true;

        TeleporterShow?.SetActive(false);
        TeleporterHide?.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TeleporterShow != null)
        {
            TeleporterShow.SetActive(true);
        }

        if (TeleporterHide != null)
        {
            TeleporterHide.SetActive(true);
        }
    }
}
