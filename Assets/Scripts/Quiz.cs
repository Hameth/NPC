using System;
using System.Collections;
using System.Collections.Generic;
using Proyecto26;
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

    void Start()
    {
        SelectQuestion();
    }

    void SelectQuestion()
    {
        selectedQuestion = _questions[cnt];
        _quizUi.SetQuestion(selectedQuestion);
    }

    private void GetResult(int pts)
    {
        gameMenu.SetActive(false);
        _menu.SetActive(true);
        _menu.GetComponentInChildren<TextMeshProUGUI>().text = "Puntaje\n" + pts;
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

        Invoke("SelectQuestion", 0.4f);
        return correctAns;
    }

    public void getQuestions()
    {
        RetrieveFromDatabase();
    }

    public void RetrieveFromDatabase()
    {
        RestClient.Get("https://npc-unity.firebaseio.com/Pregunta_1.json").Then(response =>
        {
            Debug.Log(response.Text);
        });
    }
}

[Serializable]
public class Question
{
    public string question;
    public string correctAns;
    public List<string> options;
}