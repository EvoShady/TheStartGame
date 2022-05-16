using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControllerScript : MonoBehaviour
{
    private static bool isFirstPersonView = false;
    public CinemachineVirtualCamera firstPersonCamera;
    public CinemachineFreeLook thirdPersonCamera;
    public SkinnedMeshRenderer meshRendererFirstPersonView;

    private void Start()
    {
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
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
        meshRendererFirstPersonView.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }
    private void SetFirstPersonView()
    {
        isFirstPersonView = true;
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        meshRendererFirstPersonView.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }
}
