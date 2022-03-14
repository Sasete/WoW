using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasBasYukselManager : MonoBehaviour
{
    
    public Slider slider;

    public void UpdateSlider()
    {

        int current = FindObjectOfType<clickcounter>().amount;


        if(current >= slider.maxValue)
            current = (int)slider.maxValue;

        slider.value = current;

    }

    public void CheckLevelFinish()
    {

        int current = FindObjectOfType<clickcounter>().amount;

        if(current >= slider.maxValue)
            Debug.Log("Bitti");

    }

}
