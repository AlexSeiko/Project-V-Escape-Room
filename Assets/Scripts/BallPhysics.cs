/*using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRGrabbableWithPhysics : XRGrabInteractable
{
    private Rigidbody rb;
    private Transform ballTransform;
    private XRBaseInteractor grabbingInteractor;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        grabbingInteractor = args.interactor;

        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();

        // Find the ball inside the object
        ballTransform = transform.Find("Ball"); // Adjust "Ball" to the actual name of your ball GameObject

        // Make the object kinematic while being held to avoid unwanted physics interactions
        rb.isKinematic = true;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        // Release the object
        ReleaseObject();
    }

    private void ReleaseObject()
    {
        rb.isKinematic = false;

        // Apply velocity from the interactor to the object
        if (grabbingInteractor)
        {
            rb.velocity = grabbingInteractor.GetComponent<XRBaseController>().velocity;
            rb.angularVelocity = grabbingInteractor.GetComponent<XRBaseController>().angularVelocity;

            // Apply the same velocity to the ball
            if (ballTransform)
            {
                ballTransform.GetComponent<Rigidbody>().velocity = grabbingInteractor.GetComponent<XRBaseController>().velocity;
                ballTransform.GetComponent<Rigidbody>().angularVelocity = grabbingInteractor.GetComponent<XRBaseController>().angularVelocity;
            }
        }

        grabbingInteractor = null;
    }
}*/
