using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    private Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(moveDirection != Vector2.zero)
        {
            transform.position += new Vector3(moveDirection.x, 0f, moveDirection.y) * Time.deltaTime;
        }
    }

    private void OnJump()
    {
        Debug.Log("Jump");

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            //Pressed it this frame
        }

        if(context.canceled)
        {
            //Released this frame
        }
        Debug.Log("Move");
        moveDirection = context.ReadValue<Vector2>();

        
    }

}
