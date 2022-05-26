using UnityEngine;

public class CameraViewTrigger : MonoBehaviour
{

    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().CameraViewTriggerEnter();
            isTriggered = true;
            FindObjectOfType<AudioManager>().Play("Camera Switch Voice");
        }
    }
}
