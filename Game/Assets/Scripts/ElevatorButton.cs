using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : Interactable
{

    public Animator elevatorAnimator;

    public override string GetDescription()
    {
        return "Press [E] to use the elevator";
    }

    public override void Interact()
    {
        elevatorAnimator.Play("ElevatorUpAnimation");
    }
}
