using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canonfire : MonoBehaviour
{
    public GameObject projectile;
    public Transform SpawnPosition;
    public float speed = 500f;


    public void Firecannon()
    {
        GameObject go = Instantiate(projectile, SpawnPosition.position, SpawnPosition.rotation);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * speed);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
