using PuzzleEvents;
using System.Collections.Generic;
using UnityEngine;

public class SequencedButtonPress : MonoBehaviour, PuzzleInterface
{
    [SerializeField] private List<GameObject> ButtonOrder = new List<GameObject>();
    private int currentIndex = 0;
    

    private bool IsPuzzleComplete = false;
    
    [SerializeField] private Animator animator = null;
    [SerializeField] private string AnimatorStateToPlayOnCompletion = "OpenLid";
    [SerializeField] private AudioSource Source = null;
    
    [SerializeField] private OnPuzzleCompletedEvent OnPuzzleCompleted;
    
    // Update is called once per frame
    private void OnButtonPressed(GameObject button)
    {
        if( button != ButtonOrder[currentIndex++] )
        {
            ResetPuzzle();
            return;
        }

        if (currentIndex == ButtonOrder.Count)
        {
            IsPuzzleComplete = true;
            
            OnPuzzleCompleted.Invoke();
        }
    }

    private void ResetPuzzle()
    {
        currentIndex = 0;
    }

    public bool IsComplete()
    {
        if (animator)
        {
            animator.enabled = true;
            animator.Play("Rotate Table Door");
        }
        if (Source)
            Source.Play();

        return IsPuzzleComplete;
    }
}
