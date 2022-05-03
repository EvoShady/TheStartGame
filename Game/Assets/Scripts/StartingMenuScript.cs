using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingMenuScript : MonoBehaviour
{
    private bool isAboutTabActive = false;
    public GameObject aboutPanel;
    public GameObject mainMenu;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void About()
    {
        if (isAboutTabActive)
        {
            aboutPanel.SetActive(false);
            mainMenu.SetActive(true);
            isAboutTabActive = false;
        }
        else
        {
            aboutPanel.SetActive(true);
            mainMenu.SetActive(false);
            isAboutTabActive = true;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
