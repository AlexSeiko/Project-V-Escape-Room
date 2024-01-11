using PuzzleEvents;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using static Unity.VisualScripting.Member;

public class BattleshipsPuzzle : MonoBehaviour, PuzzleInterface
{
    [SerializeField] private List<GameObject> AllCubes = new List<GameObject>();
    [SerializeField] private List<GameObject> ValidObjects = new List<GameObject>();

    private bool IsPuzzleComplete = false;

    [SerializeField] private AudioSource Source = null;

    private List<GameObject> SuccessfulAttempts = new List<GameObject>();
    private List<GameObject> FailedAttempts = new List<GameObject>();

    [SerializeField] private GameObject Magnifier;

    private void Start()
    {
        Magnifier?.SetActive(false);
    }
    public void OnPlayerTouchedObject(GameObject TouchedObject)
    {
        if(SuccessfulAttempts.Contains(TouchedObject) || FailedAttempts.Contains(TouchedObject))
            return;

        if (ValidObjects.Contains(TouchedObject))
        {
            SuccessfulAttempts.Add(TouchedObject);
            
            TouchedObject.GetComponentInChildren<MeshRenderer>().material.SetColor("_BaseColor", Color.green);
        }
        else
        {
            FailedAttempts.Add(TouchedObject);
            
            TouchedObject.GetComponentInChildren<MeshRenderer>().material.SetColor("_BaseColor", Color.red);
        }

        if (SuccessfulAttempts.Count == ValidObjects.Count)
        {
            IsPuzzleComplete = true;
            
            return;
        }

        if (FailedAttempts.Count >= 3)
        {
            // Reset Board
            SuccessfulAttempts.Clear();
            FailedAttempts.Clear();

            for (int i = 0; i < AllCubes.Count; ++i)
            {
                AllCubes[i].GetComponentInChildren<MeshRenderer>().material.SetColor("_BaseColor", Color.white);

            }
        }

        IsPuzzleComplete = true;

    }

    public bool IsComplete()
    {
        if (Source)
            Source.Play();

        if (Magnifier != null)
        {
            Magnifier.SetActive(true);
        }

        return IsPuzzleComplete;
    }
}
