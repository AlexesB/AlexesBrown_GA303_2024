using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Allows us to manipulate Unity functions

public class Practice : MonoBehaviour //Class Declaration
{
    public int numb1; //int is 4 bytes
    public int numb2; //pubulic or private, then datatype, then name of variable

    public long num3; //long is 8 bytes

    public uint num4; //uint is _STILL_ 4 bytes
    public ulong num5; //ulong is _STILL_ 8 bytes

    //DECIMALS
    public float numb6 = 3.1415f; //float is 4 bytes 0 stores decimals up to 6-7 digits
    public double numb7 = 3.14159265; //Double is 8 bytes - stores decimal numbers up to 15. More precision with double

    //TRUE OR FALSE
    public bool isProgrammingHard = true; //bool is 1 bit- only stores true/false or 0/1

    
    //DATA SIZES
    //1 Byte= 8 bits; 256 numbers (0-255)
    //1024 Bytes = 1 Kilobyte
    //1024 Kilobytes = 1 Megabyte
    //1024 Megabytes = 1 Gigabyte
    //1024 Gigbytes = 1 Terabyte

    //300Mbps - Is not 300MBps - instead it's 300 Megabits per second (lowercase b = byte uppercase B= bit)
    //1 Gigabit internet = download speed of 125 MegaBYTES per second max

    //TEXT VARIABLES
    public char charizard = 'a';
    public char blastoise = 'b';
    public char venusaur = 'c';

    public string monsters = "Stinky pokemon yappig to much, sentence can be long. Im entering random sentences here to help with demo stuff";
    // hit enter after writing long threads it'll syntax the sentences and the sentence will end on whatever the last word of the sentence was.

    //THESE ARE DATATYPES?
    public Light light; 
    public Transform

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("The starting nummber for numb1 is: " + numb1);
        numb1 = numb1 + 1;
        Debug.Log("The end number for numb1 after adding 1 is: " +numb1);


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(charizard);
        
    }
}
