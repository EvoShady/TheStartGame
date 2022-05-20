using UnityEngine;

public class PlatformCheckScript : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;
    }
}
