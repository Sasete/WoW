using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public static Player instance;


    [Range(0,100)]
    public int socialPressure;

    public int currentLevel = 0;

    public void Start()
    {

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

    }

    public void NextLevel()
    {
        currentLevel++;

        if (currentLevel > 7)
            currentLevel = 0;

        SceneManager.LoadScene(currentLevel);

    }
    



}
