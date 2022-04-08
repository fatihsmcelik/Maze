using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float seconds;
float minutes;
[SerializeField] Text stopwatchText;
    // Start is called before the first frame update
    void Start()
    {
        seconds = (int)(Player.timer%60);
            minutes = (int)(Player.timer/60);
            
        stopwatchText.text = minutes.ToString("00")+":"+seconds.ToString("00");
    }

    // Update is called once per frame
    
}
