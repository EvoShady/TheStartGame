using UnityEngine;

public class MovementTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().MovementTriggerEnter();
            isTriggered = true;
        }
    }
}
