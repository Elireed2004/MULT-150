using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EReed_Hour9MovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; // You can adjust this in the Inspector

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Left/Right arrows or A/D
        float moveZ = Input.GetAxis("Vertical");   // Up/Down arrows or W/S

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }
}
