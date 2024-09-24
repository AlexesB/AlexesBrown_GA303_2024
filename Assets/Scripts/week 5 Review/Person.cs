using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    
    [SerializeField] private string myname;
    [SerializeField] private int age;
    [SerializeField] private string favoriteMovie;
    [SerializeField] private string profession;
    [SerializeField] private string introduceSelf;

   
    public Color hairColor;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroduceSelf()
    {
        Debug.Log(introduceSelf);

    }
    public string GetName()
    {
        return myname;
    }

    public void ChangeName(string newName)
    {
        myname = newName;
    }
}
