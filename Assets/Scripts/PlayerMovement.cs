﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public Transform groundCheck;
    public Transform ceilingCheck;
    public float checkDistance = 0.4f;
    public LayerMask groundMask;

    public float speed = 12f;
    public float gravity = -75f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -1f;

        if (!isGrounded && Physics.CheckSphere(ceilingCheck.position,checkDistance, groundMask))
            velocity.y = -1f;

        if (Input.GetButtonDown("Jump") && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravity);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (controller.transform.position.y < -17)
        {
            controller.transform.position = new Vector3(473, 25, -32);
            controller.transform.rotation = new Quaternion(0, 176, 0, 0);
        }
    }
}
