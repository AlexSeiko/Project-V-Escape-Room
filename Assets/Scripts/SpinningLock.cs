using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningLock : MonoBehaviour
{
    private float LockSegments = 9.0f;
    private float LockAngleSegments = 0.0f;
    
    public int GetLockNumber()
    {
        float EulerAngle = transform.localRotation.eulerAngles.y;
        if (EulerAngle > 360)
            EulerAngle -= 360;

        if (EulerAngle < -360)
            EulerAngle += 360;
        
        return (int)(1 + LockSegments - Mathf.Round(EulerAngle / LockAngleSegments));
    }

    private void Start()
    {
        LockAngleSegments = 360.0f / LockSegments;
    }

    private void Update()
    {
        Debug.Log(GetLockNumber());
    }
}
