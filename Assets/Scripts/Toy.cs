using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Toy : MonoBehaviour
{


    public UnityEvent onClick;

    public void Start()
    {
        if(onClick == null)
            onClick = new UnityEvent();
    }

    public void InvokeAnswer()
    {

        InvokeAnswer();

    }

    public void RightAnswer()
    {
        LevelManager.level.NextLevel();
    }

    public void WrongAnswer()
    {
        LevelManager.level.NextLevel();
    }

}
