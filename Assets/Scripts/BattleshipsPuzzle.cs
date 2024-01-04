using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BattleshipsPuzzle : MonoBehaviour, PuzzleInterface
{
    [SerializeField] private List<GameObject> AllCubes = new List<GameObject>();
    
    [SerializeField] private List<GameObject> ValidObjects = new List<GameObject>();

    private List<GameObject> SuccessfulAttempts = new List<GameObject>();
    private List<GameObject> FailedAttempts = new List<GameObject>();

    private bool IsPuzzleComplete = false;

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
    }

    public bool IsComplete()
    {
        return IsPuzzleComplete;
    }
}
