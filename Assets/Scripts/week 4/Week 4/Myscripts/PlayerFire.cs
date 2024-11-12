using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public List<Canonfire> cannons = new List<Canonfire>();
    //WHEN MAKING A LIST YOU NEED TO REFERENCE THE SCRIPT OF LISTED ITEMS. ITEMS NEED TO HAVE LISTED SCRIPT IN ORDER TO WORK!!
    public int currentCannon = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            IncreaseCannonNumber();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DecreaseCannonNumber();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            FireAll();
        }
    }

    public void FireCannon()
    {
        cannons[currentCannon].FireCannon();
        Debug.Log("Was he the killer?");

    }

    public void IncreaseCannonNumber()
    {
        if (currentCannon < cannons.Count - 1)
        {
            currentCannon++;
            Debug.Log("Current one selected is " + cannons[currentCannon]);
        }
    }

    public void DecreaseCannonNumber()
    {
        if (currentCannon > 0)
        {
            currentCannon--;
            Debug.Log("Current one selected is " + cannons[currentCannon]);
        }
    }
    public void FireAll()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();

        }
        Debug.Log("Did u catch that?");

    }
}
