using UnityEngine;

public class SprintAndJumpTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().SprintAndJumpTriggerEnter();
            isTriggered = true;
            FindObjectOfType<AudioManager>().Play("Sprint And Jump Voice");
        }
    }
}
