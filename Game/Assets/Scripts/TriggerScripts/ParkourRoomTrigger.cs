using UnityEngine;

public class ParkourRoomTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            FindObjectOfType<TutorialController>().PakrourRoomTrigger();
            isTriggered = true;
            FindObjectOfType<AudioManager>().Play("Parkour Room Voice");
        }
    }
}
