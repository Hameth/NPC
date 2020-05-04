using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject menuButton;
    
    public void Resume()
    {
        menuButton.SetActive(true);
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        menuButton.SetActive(false);
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Dead()
    {
        menuButton.SetActive(false);
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
}
