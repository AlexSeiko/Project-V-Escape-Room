using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnAllPuzzlesCompleted : UnityEvent { }

public class EscapeRoomManager : MonoBehaviour
{
    private List<PuzzleInterface> PuzzlesInLevel = new List<PuzzleInterface>();

    public OnAllPuzzlesCompleted OnAllPuzzlesCompletedEvent;
    
    private void Start()
    {
        PuzzlesInLevel = FindObjectsOfType<MonoBehaviour>().OfType<PuzzleInterface>().ToList();
    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < PuzzlesInLevel.Count; ++i)
        {
            if (!PuzzlesInLevel[i].IsComplete())
            {
                return;
            }
        }
        
        OnAllPuzzlesCompletedEvent.Invoke();
    }
}
