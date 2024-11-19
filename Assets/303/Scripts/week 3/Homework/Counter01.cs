using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter01 : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision points)
    {
        
        Debug.Log("Suprise!");
        if(points.collider.gameObject.tag == "Pill")
        {
            Debug.Log("nobody needs to know...");
            Destroy(this.gameObject);

        }

    }

}
