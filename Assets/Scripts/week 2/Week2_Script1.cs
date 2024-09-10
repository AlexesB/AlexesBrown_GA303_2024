using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2_Script1 : MonoBehaviour
{
    public Week2_Script2 ourOtherScript;
    public Light lettherebelight;
    public Light anotherlight;

    public Color lightcolor;


    // Start is called before the first frame update
    void Start()
    {
        ourOtherScript.counter++;

        lettherebelight.intensity = 2f;
        lettherebelight.color = Color.blue;
        lettherebelight.range = 25f;

        lettherebelight.color = lightcolor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
