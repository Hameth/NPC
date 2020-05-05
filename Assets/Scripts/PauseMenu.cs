using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject menuButton;
    [SerializeField] private GameObject tip;
    public void Resume()
    {
        menuButton.SetActive(true);
        pauseMenuUi.SetActive(false);
        tip.SetActive(false);
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

    public void Regame()
    {
        SceneManager.LoadScene("Game v2");
    }

    public void PauseTip()
    {
        tip.SetActive(true);
        tip.GetComponentInChildren<TextMeshProUGUI>().text = "1"; //funcion que trae tips
        Pause();
    }

    public void Dead()
    {
        menuButton.SetActive(false);
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
}
