using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasBasYukselManager : MonoBehaviour
{
    
    public Slider slider;

    private float time = 0;
    public float speed = 1;

    public void UpdateSlider()
    {

        int current = FindObjectOfType<clickcounter>().amount;


        if(current >= slider.maxValue)
            current = (int)slider.maxValue;

        slider.value = current;

    }

    public void Update()
    {
        if (Player.player.paused)
            return;

        time += Time.deltaTime * speed;

        if(time > 1)
        {

            int current = FindObjectOfType<clickcounter>().amount;

            if (current <= 0)
                return;


            int passedTime = Mathf.FloorToInt(time);
            current -= passedTime;
            time -= passedTime;

            FindObjectOfType<clickcounter>().amount = current;

            slider.value = current;

        }

    }

    public void CheckLevelFinish()
    {

        int current = FindObjectOfType<clickcounter>().amount;

        if (current >= slider.maxValue)
        {
            LevelManager.level.Succeed();
            LevelManager.level.NextLevel();
        }

    }

}
