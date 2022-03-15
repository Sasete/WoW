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

        if (Player.player.paused)
            return;

        InvokeAnswer();
    }

    public void InvokeAnswer()
    {

        onClick.Invoke();

    }

    public void RightAnswer()
    {
        LevelManager.level.Succeed();
        LevelManager.level.NextLevel();
    }

    public void WrongAnswer()
    {
        LevelManager.level.Failed();
        LevelManager.level.NextLevel();
    }

}
