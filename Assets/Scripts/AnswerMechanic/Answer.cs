using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{

    public bool rightAnswer = false;



    public void InvokeAnswer()
    {

        if (rightAnswer)
            FindObjectOfType<AnswerManager>().RightAnswer();
        else
            FindObjectOfType<AnswerManager>().WrongAnswer();

    }





}
