using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Utilities : MonoBehaviour
{
    public static IEnumerator Type(string text, TextMeshProUGUI textField, AudioSource source)
    {

        source.loop = true;
        source.Play();
        textField.text = "";

        foreach(char letter in text.ToCharArray())
        {
             
            textField.text += letter;

            yield return new WaitForSeconds(.1f);
        }

        source.Stop();
    }
}
