using UnityEngine;

public class EndCutsceneTrigger : MonoBehaviour
{

    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().EndCutsceneTriggerEnter();
            isTriggered = true;
        }
    }
}
