using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Public variables
    public GameObject player;
    private Vector3 offset;
    public float turnSensitivity = 100;

    // Start is called before the first frame update
    void Start()
    {
        // Camera Transform Position - Player Transform Position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame but runs when all other updates are done
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        // If user presses "E" or "Mouse Button 2", rotate camera right
        if (Input.GetKey(KeyCode.E) || Input.GetMouseButton(1))
        {
            transform.RotateAround(player.transform.position, Vector3.up, turnSensitivity * Time.deltaTime);
            offset = transform.position - player.transform.position;
        }
        // If user presses "Q" or "Mouse Button 1", rotate camera left
        else if (Input.GetKey(KeyCode.Q) || Input.GetMouseButton(0))
        {
            transform.RotateAround(player.transform.position, Vector3.up, -turnSensitivity * Time.deltaTime);
            offset = transform.position - player.transform.position;
        }
    }
}
