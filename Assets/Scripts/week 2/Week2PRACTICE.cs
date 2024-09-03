using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2PRACTICE : MonoBehaviour
{
    public GameObject superCoolBallObject;
    public int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        //superCoolBallObject = GameObject.Find("Spiderman");

        
       // GameObject.Find("Sphere").transform.SetParent(null);
        superCoolBallObject = GameObject.Find("Sphere");
        superCoolBallObject.SetActive(false);
        //gameObject.SetActive(false); //this would turn off the gameObject in the scene
        //gameObject.SetActive(true); //Turns on the gameObject in the scene
        //gameObject.transform.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
