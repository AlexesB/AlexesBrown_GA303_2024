using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//I  came in late mixed up class times :(
public class Compound : MonoBehaviour
{
    public GameObject superCoolBallObject;


    // Start is called before the first frame update
    void Start()
    {

        superCoolBallObject = GameObject.Find("Sphere");
        superCoolBallObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
