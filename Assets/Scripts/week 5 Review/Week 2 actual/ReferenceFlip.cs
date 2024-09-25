using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReferenceFlip : MonoBehaviour
{
    public Toggle toggleUI;
    public Toggle switchImage;
    public Image wayneImage;
    public Image bowieImage;
    public Image rajImage;

    public Sprite spriteRef;
    public Image rajSprite;
    public Image wayneSprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleON()
    {
        if (toggleUI.isOn)
        {
            bowieImage.enabled = true;
            Debug.Log("Hello Bowie :D!");
        }
        else
        {
            bowieImage.enabled = false;
            Debug.Log("OH, bowie's gone but Raj is here :D");

        }
    }

    public void FlipWayne90()
    {
        wayneImage.rectTransform.Rotate(new Vector3(0f, 0f, 90f));
        Debug.Log("Don't leave me halfway D: keep spinning!");
    }

    public void FlipWayne()
    {
        wayneImage.rectTransform.Rotate(new Vector3(0f, 180f, 0f));
        Debug.Log("Woah, That was a crazy flip!");

    }

  
}
