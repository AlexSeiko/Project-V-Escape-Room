using System.Collections.Generic;
using UnityEngine;

public class SpinningLockPuzzle : MonoBehaviour, PuzzleInterface
{
    [SerializeField] private List<int> PuzzleCombination = new List<int>();
    [SerializeField] private List<SpinningLock> SpinningLocks = new List<SpinningLock>();

    private bool IsPuzzleComplete = false;

    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private OnPuzzleCompletedEvent OnPuzzleCompleted;
    
    void Update()
    {
        if (IsPuzzleComplete)
            return;

        if (IsCorrectCombination())
        {
            IsPuzzleComplete = true;
            
            Debug.Log("Completed!");

            // Do Whatever you need to do here.
            if(animator)
                animator.Play("OpenDoor");
            
            if(audioSource)
                audioSource.Play();
        }
    }

    private bool IsCorrectCombination()
    {
        for (int i = 0; i < SpinningLocks.Count; ++i)
        {
            if (PuzzleCombination[i] != SpinningLocks[i].GetLockNumber())
                return false;
        }

        return true;
    }

    public bool IsComplete()
    {
        return IsPuzzleComplete;
    }
}
