using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SphereCollider))]
public class OpenWhenInCloseProximity : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            animator.Play("Open");
        }
    }
    
    private void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            animator.Play("Close");
        }
    }
}
