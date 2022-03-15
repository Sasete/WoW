using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sperm : MonoBehaviour
{

    public float speed;

    public float speedRange;

    public Vector2 xLimit;

    private bool selected = false;

    public void Start()
    {
        speed = Random.Range(speed - speedRange, speed + speedRange);
        GetComponent<Animator>().speed = speed;
    }

    public void Update()
    {
        MoveRight();

        if(transform.position.x > xLimit.y)
        {
            if (selected)
            {

                LevelManager.level.Succeed();
                LevelManager.level.NextLevel();
                Destroy(gameObject);

            }

            transform.position = new Vector3(xLimit.x, transform.position.y, transform.position.z);
        }
                
    }

    public void OnClick()
    {


        Select();

    }

    public void MoveRight()
    {
        transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
    }

    public void Select()
    {
        speed *= 10;
        GetComponent<Animator>().speed = speed;
        selected = true;
    }

}
