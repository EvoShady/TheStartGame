using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().ElevatorTriggerEnter();
            isTriggered = true;
            FindObjectOfType<AudioManager>().Play("Take Elevator Voice");
        }
    }
}
