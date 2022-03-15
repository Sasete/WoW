using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    public float textureWidth;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;

        textureWidth = sprite.texture.width / sprite.pixelsPerUnit;
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(Time.deltaTime * speed, 0, 0);

        if(Mathf.Abs(transform.position.x) >= textureWidth)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);

    }
}
