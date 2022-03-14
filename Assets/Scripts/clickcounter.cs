using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class clickcounter : MonoBehaviour
{
    
    public int amount = 0;
    
    public UnityEvent onClick;

    void Start()
    {

        if(onClick == null)
            onClick = new UnityEvent();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
            Clicked();

    }

    public void Clicked()
    {
        
        amount += Random.Range(0,5);

        onClick.Invoke();

    }

}
