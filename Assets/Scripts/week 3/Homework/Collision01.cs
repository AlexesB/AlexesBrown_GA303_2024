using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision01 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision wallhit)
    {
        Debug.Log("The wall has been hit sir!");

    }
}
