using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueBehaviour : MonoBehaviour
{

    public Dialogue[] dialogues;

    public int order = 0;

    public Dialogue dialogue { get { return dialogues[order]; } }


    public TextMeshProUGUI textField;

    private Coroutine textWriter;

    public void Start()
    {

        order = 0;
        UpdateUI();

    }

    public void UpdateUI()
    {

        textWriter = StartCoroutine(Utilities.Type(dialogue.text, textField));
        
    }

    public void Accept()
    {

        dialogue.onAccept.Invoke();
        NextDialogue();

    }

    public void Reject()
    {

        dialogue.onReject.Invoke();
        NextDialogue();

    }

    public void NextDialogue()
    {

        if (dialogues.Length <= order)
        {
            order += 1;
            UpdateUI();
        }
        else
        {
            LevelManager.level.Succeed();
            LevelManager.level.NextLevel();
        }


    }


}
