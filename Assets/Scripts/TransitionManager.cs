using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager: MonoBehaviour
{
    public void ChangeToChapter1()
    {
        SceneManager.LoadScene(3);
    }


    public void ChangeToTheory()
    {
        SceneManager.LoadScene(4);
    }

    public void ChangeToHome()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeToExercise()
    {
        SceneManager.LoadScene(5);
    }

    public void ChangeToGame()
    {
        SceneManager.LoadScene(8);
    }
}
