using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Quiz _quiz;
    [SerializeField] private TextMeshProUGUI questionTxt;

    [SerializeField] private List<Button> options;

    [SerializeField] private Color correctCol, wrongCol, normalCol;

    private Question question;

    private bool answered;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => Onclick(localBtn));
        }
    }

    public void SetQuestion(Question question)
    {
        this.question = question;
        questionTxt.text = question.question;

        List<string> answerList = question.options;
        for (int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<TextMeshProUGUI>().text = answerList[i];
            
            
            
            options[i].name = answerList[i];
            options[i].image.color = normalCol;
            
        }

        answered = false;
    }

    // Update is called once per frame
    private void Onclick(Button btn)
    {
        if (!answered)
        {
            answered = true;
            bool val = _quiz.Answer(btn.name);


            if (val)
            {
                btn.image.color = correctCol;
            }
            else
            {
                btn.image.color = wrongCol;
            }
        }
    }
}
