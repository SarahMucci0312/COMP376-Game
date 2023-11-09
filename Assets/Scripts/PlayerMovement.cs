using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController Controller;
    public float MoveSmoothTime;
    public float GravityStrength;
    public float WalkSpeed;
    public float RunSpeed;

    private Vector3 CurrentMoveVelocity;
    private Vector3 MoveDampVelocity;
    
    void Start()
    {
        Controller = GetComponent<CharacterController>(); 
    }

    
    void Update()
    {
        Vector3 PlayerInput = new Vector3
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0f,
            z = Input.GetAxisRaw("Vertical")
        };

        if (PlayerInput.magnitude > 1f)
        {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput);
        float CurrentSpeed = Input.GetKey(KeyCode.LeftShift) ? RunSpeed : WalkSpeed;

        CurrentMoveVelocity = Vector3.SmoothDamp(
        CurrentMoveVelocity, MoveVector * CurrentSpeed, ref MoveDampVelocity, MoveSmoothTime);

        Controller.Move(CurrentMoveVelocity * Time.deltaTime); 

    }
}
