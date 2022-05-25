using UnityEngine;
using TMPro;

public class TutorialController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI eventText;
    [SerializeField] GameObject textBackground;
    [SerializeField] GameObject healthBar;
    [SerializeField] GameObject elevator;
    [SerializeField] bool isEventActive = false;

    public void MovementTriggerEnter()
    {
        eventText.SetText("Press W,A,S,D To Move." +
            "\nUse Mouse To Look Around");
        textBackground.SetActive(true);
        isEventActive = true;
    }
    public void SprintAndJumpTriggerEnter()
    {
        eventText.SetText("Press L.Shift To Sprint And SPACE To Jump.");
        textBackground.SetActive(true);
        isEventActive = true;
    }
    public void JumpGapTriggerEnter()
    {
        eventText.SetText("Looks Like We Have To Jump This Gap To Get To That Door." +
            "\nBe Careful!");
        textBackground.SetActive(true);
        isEventActive = true;
    }
    public void FallDamageTriggerEnter()
    {
        eventText.SetText("Falling from an excessive height will result in you taking fall damage." +
            "\nBe careful, you are not indestructible.");
        textBackground.SetActive(true);
        MakeHealthBarVisible();
        isEventActive = true;
        FindObjectOfType<PlayerDamageScript>().TakeDamage(12);
    }
    public void ElevatorTriggerEnter()
    {
        eventText.SetText("Since you can't climb out of here, just take the elevator and continue.");
        textBackground.SetActive(true);
        MakeElevatorVisible();
        isEventActive = true;
    }

    public void CameraViewTriggerEnter()
    {
        eventText.SetText("To switch between third person view and first person view press F.");
        textBackground.SetActive(true);
        isEventActive = true;
    }
    public void PakrourRoomTrigger()
    {
        eventText.SetText("This Next Room Is Made To Test Your Ability To Navigate In The Environment." +
            "\nGet To The Next Door.");
        textBackground.SetActive(true);
        isEventActive = true;
    }
    private void MakeHealthBarVisible()
    {
        healthBar.SetActive(true);
    }

    private void MakeElevatorVisible()
    {
        elevator.SetActive(true);
    } 

    public void ResetText()
    {
        eventText.SetText("");
        textBackground.SetActive(false);
        isEventActive = false;
    }

    private void Update()
    {
        if (isEventActive)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ResetText();
            }
        }
    }
}

