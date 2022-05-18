using UnityEngine;
using Cinemachine;

public class CameraControllerScript : MonoBehaviour
{
    private static bool isFirstPersonView = true;
    public CinemachineVirtualCamera firstPersonCamera;
    public CinemachineFreeLook thirdPersonCamera;
    public SkinnedMeshRenderer meshRendererFirstPersonView;
    public GameObject FirstPersonCrosshair;

    private void Start()
    {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        FirstPersonCrosshair.SetActive(true);
        meshRendererFirstPersonView.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isFirstPersonView)
            {
                SetThirdPersonView();
            }
            else
            {
                SetFirstPersonView();
            }
        }
    }

    private void SetThirdPersonView()
    {
        isFirstPersonView = false;
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
        FirstPersonCrosshair.SetActive(false);
        meshRendererFirstPersonView.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }
    private void SetFirstPersonView()
    {
        isFirstPersonView = true;
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        FirstPersonCrosshair.SetActive(true);
        meshRendererFirstPersonView.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }
}
