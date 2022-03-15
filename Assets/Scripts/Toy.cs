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

    public void OnMouseDown()
    {
        InvokeAnswer();
    }

    public void InvokeAnswer()
    {

        onClick.Invoke();

    }

    public void RightAnswer()
    {
        Debug.Log("Right Answer");
        LevelManager.level.NextLevel();
    }

    public void WrongAnswer()
    {
        Debug.Log("Wrong Answer");
        LevelManager.level.NextLevel();
    }

}
