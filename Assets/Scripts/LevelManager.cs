using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager level;

    public float time = 0;

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

        time += Time.deltaTime;

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

}

