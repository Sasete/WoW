using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{


    public static GameSystem instance;


    [Range(0,100)]
    public int socialPressure;

    public int currentScene = 0;

    public void Start()
    {

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

    }

    public void NextScene()
    {
        currentScene++;

        if (currentScene > 7)
            currentScene = 0;

        SceneManager.LoadScene(currentScene);

    }
    



}
