using UnityEngine;

public class JumpGapTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().JumpGapTriggerEnter();
            isTriggered = true;
        }
    }
}
