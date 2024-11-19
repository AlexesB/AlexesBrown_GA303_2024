using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialouge : MonoBehaviour
{
    public string myname = "Scott";
    public int age = 25;
    public string profession = "Comic Book Writer";
    public string favoriteMovie = "Scott Pilgrim";
    public int elleFriendshipPoints = 0;
    public int santaclauseFriendshipPoints = 0;
    public int colonelSandersFriendshipPoints = 0;

    //public GameObject elleObject; referencing other objects in the scene.

    public Person elle;
    public Person santaClause;
    public Person colonelSanders;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(elle.hairColor);

        Debug.Log(elle.GetName());

        IntroduceSelf();

        //elleObject.GetComponent<Person>(). ChangeName( "New Name :"); a way to get components off a specific script on an object you interact with.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroduceSelf()
    {

        Debug.Log("Hello my name is " + myname + " ,nice to meet you!");
    }

    public void AskFavoriteMovie()
    {
        Debug.Log("What's your favorite movie?");

    }

    public void AskEmbarrassingMoment()
    {
        Debug.Log("What's your favorite movie?");

    }

    public void AskToShowImpressiveSkill()
    {
        Debug.Log("What is your impressive skill?");

    }

    public void ComplimentOnSkill()
    {
        Debug.Log("Wow that was really awesome of you");

    }

    public void ShareInterest()
    {
        Debug.Log("Well I myself am skilled too! watch me.");

    }
}
