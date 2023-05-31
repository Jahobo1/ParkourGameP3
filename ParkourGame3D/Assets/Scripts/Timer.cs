using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    
    private float startTime;
    private bool Finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Finished)
        {
            return;
        }

    
        float t = Time.time - startTime;

        string minutes = ( (int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        
        TimerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        Finished = true;
        TimerText.color = Color.yellow;
    }
}
