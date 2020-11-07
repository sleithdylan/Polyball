using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float speed = 0;
    public Transform CameraPivot;
    public Transform cam;

    // Private variables
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    Vector2 input;

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

        // X movementValue
        movementX = movementVector.x;
        // Y movementValue
        movementY = movementVector.y;
    }

    void Update()
    {
        // Get X & Y Axis
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;
        camForward = camForward.normalized;
        camRight = camRight.normalized;

        // Adds movement
        transform.position += (camForward * input.y + camRight * input.x) * Time.deltaTime * 1.5f;
    }

    // Physics
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddRelativeForce(movement * speed);
    }
}
