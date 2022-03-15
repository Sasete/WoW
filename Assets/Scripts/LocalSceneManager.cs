using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalSceneManager : MonoBehaviour
{


    public void LoadScene(int order)
    {

        SceneManager.LoadScene(order);

    }

}
