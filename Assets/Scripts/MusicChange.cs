using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private AudioSource Background;
    [SerializeField] private AudioSource Adventure;

    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }
    private void OnTriggerEnter(Collider Other)
    {
        Background.Stop();
        Adventure.Play();
        
    }
}