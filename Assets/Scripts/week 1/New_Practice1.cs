using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Practice1 : MonoBehaviour
{
    public char nolan = 'r';
    public char west = 'o';
    public char chen = 'k';
    public char bradford = 'i';
    public char lopez = 'e';
    public char grey = 'T';
    public char wesley = 'h';

    public int pochita;
    public int denji;

    public int power;
    public int chainsaw;

 
    // Start is called before the first frame update
    // adding Debug.Log will add more strings to the console. Not quite sure how to limit that but we'll try XD
    void Start()
    {
        Debug.Log("The " + nolan.ToString() + west.ToString() + west.ToString() + chen.ToString() + bradford.ToString() + lopez.ToString() + " is the show I'm currently enjoying!");

        Debug.Log("Starting total is " + denji);
        denji = denji + pochita;
        Debug.Log("Added " + pochita + " to total, making total " + denji);

        Debug.Log("The new starting total is " + denji);
        denji = denji * power - chainsaw;
        Debug.Log("Multiplied " + power + " and subtracted " + chainsaw + " to total, making total " + denji);

        Debug.Log("new total is " + denji);
        denji = denji / power + chainsaw;
        Debug.Log("Divided " + power + " to the total and added " + chainsaw + " to get " + denji);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
