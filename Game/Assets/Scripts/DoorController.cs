using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;

    private void Start()
    {
        doorAnimator = transform.parent.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("isDoorOpened", true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("isDoorOpened", false);
    }
}
