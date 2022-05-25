using UnityEngine;

public class FallDamageTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().FallDamageTriggerEnter();
            isTriggered = true;
        }
    }
}
