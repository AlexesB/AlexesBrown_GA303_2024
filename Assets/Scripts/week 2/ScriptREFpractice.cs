using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptREFpractice : MonoBehaviour
{
    public Week2PRACTICE ourOtherScript;
    public Light coolLightObject;
   // public Light 
  
    
    public Color lightColor;

    // Start is called before the first frame update
    void Start()
    {
        ourOtherScript.counter++; //++ = add one, -- = subtract one
        //ourOtherScript.myName = "Anthony";

        coolLightObject.intensity = 2f;
        coolLightObject.range = 25f;
        coolLightObject.color = Color.blue;

       // coolLightObjject.color = lightColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
