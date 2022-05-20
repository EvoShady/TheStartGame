using UnityEngine;

public class MovingPlatformTriggerScript : MonoBehaviour
{
    public Animator movingPlatformAnimator;

    private void OnTriggerEnter(Collider other)
    {
        movingPlatformAnimator.SetTrigger("StartMovingPlatform");
    }
}
