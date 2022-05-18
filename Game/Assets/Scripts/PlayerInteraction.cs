using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance;

    public TextMeshProUGUI interactionText;
    Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f));

        RaycastHit hit;

        bool successfulHit = false;

        if(Physics.Raycast(ray, out hit, interactionDistance))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if(interactable != null)
            {
                HandleInteraction(interactable);
                interactionText.text = interactable.GetDescription();
                successfulHit = true;
            }
        }
        if (!successfulHit)
        {
            interactionText.text = "";
        }
    }
    void HandleInteraction(Interactable interactable)
    {
        KeyCode key = KeyCode.E;
        switch (interactable.interactionType)
        {
            case Interactable.InteractableType.Press:
                if (Input.GetKeyDown(key))
                {
                    interactable.Interact();
                }
                break;
            default: throw new System.Exception("Type of interaction unknown!");
        }
    }
}
