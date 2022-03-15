using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Final_diyalog : MonoBehaviour
{
 
    [TextArea]
    public string highFreedom;
    [TextArea]
    public string highPressure;
    [TextArea]
    public string equal;
    public TextMeshProUGUI TextField;


    // Start is called before the first frame update
    void Start()
    {
        float pressure = Player.player.socialPressure;
        float freedom = Player.player.freedom;

        if (freedom > 50)
            TextField.text = highFreedom;
        else if (pressure > 50)
            TextField.text = highPressure;
        else
            TextField.text = equal;
        
        
            

    }

    
}
