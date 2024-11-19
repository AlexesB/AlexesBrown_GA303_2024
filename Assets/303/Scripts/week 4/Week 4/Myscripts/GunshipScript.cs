using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshipScript : MonoBehaviour
{
    public List<NewCannon> cannons = new List<NewCannon>();

    public int currentCannon = 0;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
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
        Debug.Log("One down more to go!");

    }

    public void IncreaseCannonNumber()
    {
        if (currentCannon < cannons.Count - 1)
        {
            currentCannon++;
        }
    }
    
    public void DecreaseCannonNumber()
    {
        if(currentCannon > 0)
        {
            currentCannon--;

        }
    }
    public void FireAll()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
            
        }
        Debug.Log("WE'RE GOING ALL IN BABY!");

    }


}

