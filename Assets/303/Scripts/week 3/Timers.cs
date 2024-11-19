using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timers : MonoBehaviour
{
    public float timerUP = 0f;
    public float timerDuration = 3f;



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       //if(timerUP < timerDuration)
        {
           // timerUP += Time.deltaTime;
        }

        timerUP += Time.deltaTime;

        if(timerUP >= timerDuration) //sets up the debug log to notify you that the timer has hit 3 seconds and whatever you put afterwards.
        {
            Debug.Log("The timer has reached " + timerDuration + " seconds! Timer is now resetted to 0. See you in " + timerDuration + "!"); //notifies u that the timer has hit 3 seconds
            timerUP = 0f; //resets the timer to 0 after hitting 3 seconds.


        }

        //Debug.Log(timerUP);
    }
}
