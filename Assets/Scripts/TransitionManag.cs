using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManag: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeToOptions()
    {
        SceneManager.LoadScene(3);
    }


    public void changeToTheory()
    {
        SceneManager.LoadScene(4);
    }

    public void changeToHome()
    {
        SceneManager.LoadScene(2);
    }

    public void changeToExercise()
    {
        SceneManager.LoadScene(5);
    }
}
