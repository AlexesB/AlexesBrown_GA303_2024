using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2_Script2 : MonoBehaviour
{
    public GameObject cubesmall;

    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        cubesmall = GameObject.Find("Cube");
        cubesmall.SetActive(false);

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Im struggling oof