using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Final_diyalog : MonoBehaviour
{
 
    [TextField]
    public string highFreedom;
    [TextField]
    public string highPressure;
    [TextField]
    public string equal;
    public TextMeshProUGUI TextField;


    // Start is called before the first frame update
    void Start()
    {
        float pressure = Player.player.socialPressure;
        float freedom = Player.player.freedom;

        if(highFreedom > 50)
            TextField.text = highFreedom;
        else if(highPressure > 50)
            TextField.text = highPressure
        else
            TextField.text = equal
        
        
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
