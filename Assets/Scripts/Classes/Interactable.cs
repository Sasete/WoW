using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{


    public GameObject highlightObject;

    public UnityEvent onClick;

    public void Start()
    {
        if(onClick == null)
            onClick = new UnityEvent();

    }

    public void OnMouseEnter()
    {
        if(highlightObject != null)
        {
            if(GetComponent<AudioSource>() != null)
                GetComponent<AudioSource>().Play();
            highlightObject.SetActive(true);
        }
    }

    public void OnMouseOver()
    {
        
        if(onClick != null)
            if(Input.GetMouseButtonDown(0))
                onClick.Invoke();

    }


    public void OnMouseExit()
    {
        if (highlightObject != null)
            highlightObject.SetActive(false);
    }



}
