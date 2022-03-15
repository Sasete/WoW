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

}
