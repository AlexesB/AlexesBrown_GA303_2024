using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    public int numTimesPressedSpace = 0;
    private float currentTimer = 0f;
    public float resetTime = .5f;

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numTimesPressedSpace++;

        }//checking to see if slected keys are pressed\

        if(numTimesPressedSpace == 1)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer > resetTime)
            {
                currentTimer = 0f;
                numTimesPressedSpace = 0;
            }
        }

        if(numTimesPressedSpace == 2)
        {
            Debug.Log("TWO SPACEBAR PUSHES");
            numTimesPressedSpace = 0;
        }
    }
}
