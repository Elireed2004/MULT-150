using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Tooltip("Multiplier for mouse movement (higher = faster camera translation)")]
    public float sensitivity = 0.1f;

    void Start()
    {
    }

    void Update()
    {
        // Read mouse axes
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Translate camera:
        // - X axis moves left/right
        // - Y axis moves up/down
        // Use local space so movement is relative to camera orientation
        transform.Translate(new Vector3(mouseX, mouseY, 0f), Space.Self);
    }
}
