using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverHover : MonoBehaviour
{

    public void OnMouseEnter(){
        transform.localScale = new Vector3(2f, 2f, 2f);

    }

    public void OnMouseExit(){
        transform.localScale = Vector3.one;
    }

}
