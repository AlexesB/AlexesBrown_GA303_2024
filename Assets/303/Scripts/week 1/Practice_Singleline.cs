using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_Singleline : MonoBehaviour
{
    public int anya;
    public int loid;
    public int yor;
    public int bond;
    public int forger;


    // Start is called before the first frame update
    void Start()
    {
        forger = forger + anya - loid * yor / bond;
        Debug.Log(forger + "+" + anya + "-" + loid + "*" + yor + "/" + bond + "= " + forger);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
