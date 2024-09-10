using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refdscript : MonoBehaviour
{
    public string rock;
    public string paper;
    public string scissors;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(rock + paper + scissors);

        //if u want to ref a component have public Light "name of light" ;
        //public SomeOtherScript [insert name here]
        //"name of light".
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
