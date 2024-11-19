using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject spawnedPrefab;

    


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spawnedPrefab);

        GameObject Tom = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);

        Tom.GetComponent<Light>().color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GameObject Tomagain = Instantiate(spawnedPrefab);

            Tomagain.GetComponent<Light>().color = Color.yellow;

            

            //Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);

        }

    }
}
