using UnityEngine;

public class SettingsMenuScript : MonoBehaviour
{
    public GameObject inGameMenu;
    public GameObject settingsMenu;

    public void CloseSettingsMenu()
    {
        inGameMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
