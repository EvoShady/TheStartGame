using UnityEngine;

public class ElevatorButton : Interactable
{

    public Animator elevatorAnimator;
    public Animator buttonAnimator;

    public override string GetDescription()
    {
        return "Press [E] to use the elevator";
    }

    public override void Interact()
    {
        buttonAnimator.SetTrigger("useButton");
        elevatorAnimator.SetTrigger("useElevator");
    }
}
