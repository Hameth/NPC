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
    [SerializeField] private int size;
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private GameObject _menu;
    private int cnt = 0;
    private int score = 0;
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
        _menu.transform.position = new Vector3(0,0,222222);
        _score.text = "Puntaje\n \n"+pts;
       
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
[System.Serializable]
public class Question
{
    public string question;
    public string correctAns;
    public List<string> options;
    public QuestionType questionType;

}
[System.Serializable]
public enum QuestionType
{
    TEXT
}
