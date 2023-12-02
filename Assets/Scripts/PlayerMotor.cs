using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class PlayerMotor : MonoBehaviour
{
    private bool isGrounded;
    public float gravity = -9.8f;
    public float jumppower = 1f;
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    void Start() 
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMovement(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void ProcessJump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumppower * -3.0f * gravity);
        }
    }
}
