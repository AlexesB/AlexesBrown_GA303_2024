using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptREFpractice : MonoBehaviour
{
    public Week2PRACTICE ourOtherScript;
    // Start is called before the first frame update
    void Start()
    {
        ourOtherScript.counter++; //++ = add one, -- = subtract one

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
