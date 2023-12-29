using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponentsOnEventCall : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> ComponentsToEnable;

    public void EnableComponents()
    {
        for (int i = 0; i < ComponentsToEnable.Count; ++i)
        {
            ComponentsToEnable[i].enabled = true;
        }
    }
}
