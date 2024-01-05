using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public enum EDrawerOpenState
{
    Closed,
    HalfOpen,
    FullyOpen
}

public class DrawerPullingState : MonoBehaviour
{
    private Vector3 InitialLocation = new Vector3();
    [SerializeField] private Vector3 FinalLocation = new Vector3();

    private float RangeMax = 0.0f;
    
    private void Start()
    {
        InitialLocation = transform.localPosition;

        RangeMax = Vector3.Distance(InitialLocation, FinalLocation);
    }

    //private void Update()
    //{
    //    Debug.Log(GetDrawerState());
    //}

    private EDrawerOpenState GetDrawerState()
    {
        float CurrentDistanceFromInitialLocation = Vector3.Distance(transform.localPosition, InitialLocation);
        float NormalizedDistance = CurrentDistanceFromInitialLocation / RangeMax;

        if (NormalizedDistance < 0.33f)
            return EDrawerOpenState.Closed;

        if (NormalizedDistance >= 0.33f && NormalizedDistance <= 0.66f)
            return EDrawerOpenState.HalfOpen;

        return EDrawerOpenState.FullyOpen;
    }
}
