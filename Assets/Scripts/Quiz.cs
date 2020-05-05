using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Quiz : MonoBehaviour
{
    
    [SerializeField] private QuizUI _quizUi;
    [SerializeField] private List<Question> _questions;

    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject _menu;
    private int cnt;
    private int score;
    private Question selectedQuestion;
    
    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();
    }    
 
    // Update is called once per frame
    void SelectQuestion()
    {
        
        selectedQuestion = _questions[cnt];
        _quizUi.SetQuestion(selectedQuestion);
        

    }

    private void GetResult(int pts)
    {
        gameMenu.SetActive(false);
        _menu.SetActive(true);
        _menu.GetComponentInChildren<TextMeshProUGUI>().text = "Puntaje\n"+pts;
        
       
    }

    private void Update()
    {
        if (cnt == _questions.Count)
        {
            GetResult(score);
        }
    }

    public bool Answer(string answered)

    {
        bool correctAns = false;
        if (answered == selectedQuestion.correctAns)
        {
            //yes
            correctAns = true;
            score++;
            cnt++;
        }
        else
        {
            //no
            cnt++;
        }
         Invoke("SelectQuestion",0.4f);
         return correctAns;
    }
    
}
[Serializable]
public class Question
{
    public string question;
    public string correctAns;
    public List<string> options;
   

}

