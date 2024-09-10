using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3_inclassnotes : MonoBehaviour
{ //transfrom, gameobjects are automatically referenced in the script along with the gameobject it's attached to
    // Start is called before the first frame update

    public Transform CubeTP;
    public Transform cameraTransform;

    public float spedd = 5f;


    void Start()
    {
        //this.transform.Translate(Vector3.right)

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.right * Time.deltaTime); //this moves the object attached to the script over to the right every second. He just slides over time

        //this.transform.position += Vector3.one * Time.deltaTime;  //drags diagonally
        // this.transform.position = new Vector3(-7.72f, 4.15f, 0f);
        //this.transform.position = CubeTP.transform.position;

        if (Input.GetKeyDown(KeyCode.H))
        {
            //this.transofrom.position = Camera.main;
            this.transform.position = cameraTransform.position;
            this.transform.position += this.transform.forward * spedd;
           // this.transform.position += Vector3.forward; //universal forward (z+1)
        }
        
        //^ will teleport to given position when played. or whenever u need
        //+= add whatever is on the right to whatever is on the left.
        //
    }
}
