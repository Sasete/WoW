using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{

    public string talker;

    public Sprite profile;

    [TextArea]
    public string text;


    public UnityEvent onAccept;
    public UnityEvent onReject;


    public Dialogue()
    {
        onAccept = new UnityEvent();
        onReject = new UnityEvent();
    }

    public void Pressure(int amount)
    {
        Player.player.socialPressure += amount;
        Player.player.UpdateUI();
    }

    public void Freedom(int amount)
    {
        Player.player.freedom += amount;
        Player.player.UpdateUI();
    }

}
