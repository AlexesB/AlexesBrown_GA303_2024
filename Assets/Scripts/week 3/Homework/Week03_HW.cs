using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week03_HW : MonoBehaviour
{
    public GameObject spawnedPrefab;

    public Transform spawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject Tom = Instantiate(spawnedPrefab, spawner.position, spawner.rotation);
            Tom.GetComponent<Light>().color = Color.cyan;

        }

    }

    public void SpawnTom()
    {
        GameObject Tom = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);

        Tom.GetComponent<Light>().color = Color.red;
    }
}
