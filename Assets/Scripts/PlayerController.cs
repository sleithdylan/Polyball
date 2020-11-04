using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float speed = 0;

    // Private variables
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        // Sets variable "rb" to Rigidbody Component which is attached to the player
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        // Gets "Vector2" data from movementValue
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // For physics
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}
