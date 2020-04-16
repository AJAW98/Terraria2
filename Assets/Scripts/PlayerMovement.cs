using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    CharacterController2D controller;

    public float speed = 40.0f;

    float horizontalMove = 0f;
    bool jump = false;

    void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            Debug.Log("Jump");
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    
}

