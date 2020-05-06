using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject menuButton;

    [SerializeField] private GameObject tip;
    private string _tipText;
    private List<string> _tips = new List<string>();
    private bool enter = false;

    public void Start()
    {
        getQuestions();
    }

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

    public void getQuestions()
    {
        RetrieveFromDatabase();
        RetrieveFromDatabase();
        string[] tips = _tipText.Split('"');
        foreach (string tip in tips)
        {
            if (tip.Length > 2)
            {
                _tips.Add(tip);
            }
        }

        _tips.RemoveAt(0);

        foreach (string tip in _tips)
        {
            Debug.Log(tip);
        }
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get("https://npc-unity.firebaseio.com/Tips.json").Then(response => { _tipText = response.Text; });
    }

    public void PauseTip()
    {
        if (enter == false)
        {
            getQuestions();
            enter = true;
        }

        string textTip = _tips[0];
        tip.SetActive(true);
        tip.GetComponentInChildren<TextMeshProUGUI>().text = textTip; //funcion que trae tips
        _tips.Remove(textTip);
        Pause();
    }

    public void Dead()
    {
        menuButton.SetActive(false);
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
}