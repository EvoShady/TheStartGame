using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;

    public AudioSource doorAudioSource;
    public AudioClip doorOpenClip;
    public AudioClip doorCloseClip;

    private void Start()
    {
        doorAnimator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("isDoorOpened", true);
        Invoke(nameof(PlayCloseDoorSound), 0.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("isDoorOpened", false);
        Invoke(nameof(PlayCloseDoorSound), 0.5f);
    }
    
    private void PlayOpenDoorSound()
    {
        doorAudioSource.PlayOneShot(doorOpenClip);
    }
    private void PlayCloseDoorSound()
    {
        doorAudioSource.PlayOneShot(doorCloseClip);
    }

}
