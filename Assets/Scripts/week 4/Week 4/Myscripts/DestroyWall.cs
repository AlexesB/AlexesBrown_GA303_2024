using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public int hits;

    void OnCollisonEnter(Collision hits)
    {
        if(hits.collider.gameObject.tag == "BayHarbor")
        {
            Debug.Log("I am the Bay Harbor Butcher!");
            Destroy(this.gameObject);
        }
    }

}
