using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public enum InteractableType
    {
        Press
    }

    public InteractableType interactionType;

    public abstract string GetDescription();
    public abstract void Interact();
}
