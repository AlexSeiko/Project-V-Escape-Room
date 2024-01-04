using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class OnPuzzleCompletedEvent : UnityEvent
{ }

public class ButtonPuzzleManager : MonoBehaviour, PuzzleInterface
{
    [SerializeField] private List<ChestButtons> Buttons = new List<ChestButtons>();
    [SerializeField] private List<EbuttonTypes> CorrectButtons = new List<EbuttonTypes>();

    private bool IsPuzzleComplete = false;
    
    [SerializeField] private Animator animator = null;
    [SerializeField] private string AnimatorStateToPlayOnCompletion = "OpenLid";
    [SerializeField] private AudioSource Source = null;
    
    [SerializeField] private OnPuzzleCompletedEvent OnPuzzleCompleted;
    
    // Update is called once per frame
    void Update()
    {
        // Lets Find All Activated Buttons
        List<ChestButtons> ActivatedButtons = new List<ChestButtons>();
        for (int i = 0; i < Buttons.Count; i++)
        {
            var button = Buttons[i];
            if (button != null)
            {
                if(button.IsPressed)
                {
                    ActivatedButtons.Add(button);
                }
            }
        }

        if(ActivatedButtons.Count == CorrectButtons.Count)
        {
            for (int i = 0; i < ActivatedButtons.Count; i++)
            {
                var button = ActivatedButtons[i];
                if (button != null)
                {
                    bool IsCorrectButtonPressed = false;
                    for (int j = 0; j < CorrectButtons.Count; j++)
                    {
                        if (button.ButtonType == CorrectButtons[j])
                        {
                            IsCorrectButtonPressed = true;
                            break;
                        }
                    }

                    if (!IsCorrectButtonPressed) return;
                }
            }

            // Do Opening Of Chest Lid
            IsPuzzleComplete = true;
            
            animator.Play(AnimatorStateToPlayOnCompletion);
            
            Source.Play();
        }
    }

    public bool IsComplete()
    {
        return IsPuzzleComplete;
    }
}
