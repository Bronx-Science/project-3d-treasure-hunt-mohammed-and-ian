using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float totalTime = 300.0f;
    public string displayedTime;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        if (totalTime <= 0.0f)
        {
            timerEnded();
        }
    }
    void displayTimeCalculator(float time)
    {
        string minutes = "" + (int)time / 60;
        string seconds = "00";
        if ((int)time % 60 != 0)
        {
            seconds = "" + (int)time % 60;
        }
        displayedTime = minutes + ":" + seconds;
    }
    void timerEnded()
    {

    }
}
