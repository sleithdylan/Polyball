using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Public variables
    public GameObject player;
    private Vector3 offset;

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
    }
}
