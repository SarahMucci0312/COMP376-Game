using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController Controller;
    public float moveSpeed;
    public float gravity = -9.81f;

    float horizontal;
    float vertical;

    Vector3 moveDirection;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;
    public GameObject canvas;
    public canvasScript CanvasScript;

    void Start()
    {
        Controller = GetComponent<CharacterController>(); 
        CanvasScript = canvas.GetComponent<canvasScript>();

    }

    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (!CanvasScript.paused)
        {

            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

            moveDirection = transform.right * horizontal + transform.forward * vertical;
            Controller.Move(moveDirection * moveSpeed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            Controller.Move(velocity * Time.deltaTime);
        }

    }
}
