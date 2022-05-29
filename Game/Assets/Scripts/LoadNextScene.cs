using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            LoadNextScene1();
        }
    }
    public void LoadNextScene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
