using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{

    public static LevelManager level;

    public float endTime = 0;
    public float time = 0;

    public TextMeshProUGUI textField;

    private bool stop = false;

    public void Start()
    {

        if(level != null)
        {
            Destroy(gameObject);
            return;
        }

        level = this;

    }

    public void Update()
    {

        if (stop)
            return;

        time += Time.deltaTime;

        if(endTime > 0)
        {

            float remainingTime = endTime - time;

            if (textField != null)
                textField.text = Format(remainingTime);


            if (remainingTime <= 0)
                stop = true;

        }



    }

    public void OnDestroy()
    {

        if(level == this)
            level = null;

    }


    public void NextLevel()
    {

        Player.player.NextLevel();
    }


    public string Format(float time)
    {

        int minute = Mathf.FloorToInt(time / 60);
        int second = Mathf.RoundToInt(time % 60);

        string retVal = minute + ":" + second.ToString("D2");

        return retVal;
    }

}

