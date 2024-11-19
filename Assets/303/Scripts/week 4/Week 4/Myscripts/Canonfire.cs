using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canonfire : MonoBehaviour
{
    public GameObject projectile;
    public Transform SpawnPosition;
    public float speed = 500f;


    public void FireCannon()
    {
        GameObject go = Instantiate(projectile, SpawnPosition.position, SpawnPosition.rotation);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * speed);

    }
   
}
