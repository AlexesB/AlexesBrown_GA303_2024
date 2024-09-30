using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raj_Sprite_Script01 : MonoBehaviour
{
    public int counter = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCounter()
    {
        if (counter > 7)
        {
            Debug.Log("Sweet! New Number for me!");

        }
    }
}
