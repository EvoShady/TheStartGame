using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private static bool gameIsPaused = false;
    public GameObject inGameMenu;
    public GameObject inGameUI;
    private string mainMenuSceneName = "MainMenu";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        inGameUI.SetActive(true);
        inGameMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void PauseGame()
    {
        inGameMenu.SetActive(true);
        inGameUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OptionsMenu()
    {
        Debug.Log("Options Menu accessed!");
        //TODO
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
