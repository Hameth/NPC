using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject menuButton;
    public GameObject deadText;

    private void OnCollisionEnter2D()
    {
        menuButton.SetActive(false);
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
}