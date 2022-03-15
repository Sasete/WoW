using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScriptKeyManager : MonoBehaviour
{


    public float[] times;

    public float duration = .5f;

    public int order = 0;

    public bool invoked = false;

    public int point = 0;

    public GameObject keyObject;

    public void Update()
    {

        if (invoked)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {

                point++;
                DeActivateKey();
                invoked = false;

                if(point >= 3)
                {
                    LevelManager.level.Succeed();
                    LevelManager.level.NextLevel();
                }

            }


            if (LevelManager.level.time >= times[order - 1] + duration)
            {

                point--;
                DeActivateKey();
                invoked = false;

            }


        }


        if (order >= times.Length)
            return;

        if(LevelManager.level.time >= times[order])
        {

            ActivateKey();
            invoked = true;
            order++;

        }

    }

    public void ActivateKey()
    {
        keyObject.SetActive(true);
    }

    public void DeActivateKey()
    {
        keyObject.GetComponentInChildren<SpriteRenderer>().color = Color.yellow;

        StartCoroutine(DeActivateAfter());

    }

    public IEnumerator DeActivateAfter()
    {

        yield return new WaitForSeconds(.2f);

        keyObject.SetActive(false);
        keyObject.GetComponentInChildren<SpriteRenderer>().color = Color.white;

    }

}
