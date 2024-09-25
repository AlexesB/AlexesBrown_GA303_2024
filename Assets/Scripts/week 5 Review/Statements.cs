using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statements : MonoBehaviour
{
    public int numTimesPressedSpace = 0;
    private float currentTimer = 0f;
    public float resetTime = .5f;
    public bool hasPlayerDoubleTappedSpace = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numTimesPressedSpace++;

            Debug.Log("ONE SPACEBAR PUSH! QUICK GET THE NEXT ONE IN!");

            if(hasPlayerDoubleTappedSpace == true)
            {
                Debug.Log("SILLY PLAYER! YOU HIT THE BAR AGAIN!");
            }

        }//checking to see if slected keys are pressed\

        if (numTimesPressedSpace == 1)
        {
          
            currentTimer += Time.deltaTime;

            if (currentTimer > resetTime)
            {
                currentTimer = 0f;
                numTimesPressedSpace = 0;
            }
        }

        if (numTimesPressedSpace == 2)
        {
            if(hasPlayerDoubleTappedSpace == true)
            {
                Debug.Log("TWO SPACEBAR PUSHES AGIAN! CONGRATS YOU DID IT!");
            }
            
            if(hasPlayerDoubleTappedSpace == false)
            {
                Debug.Log("SPACEBAR HAS BEEN PRESSED FOR THE FIRST TIME!");

            }
            hasPlayerDoubleTappedSpace = true;

            numTimesPressedSpace = 0;
            currentTimer = 0f;
        }
    }
}
