using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camercontroller : MonoBehaviour
{
    float panSpeed = 50f;
    bool isPanning = false;
    Vector3 panStartPosition;

    //// Sensitivity of mouse movement
    //public float mouseSensitivity = 100f;

    //// Reference to the camera transform
    private Transform cameraTransform;

    //// Rotation around the x-axis (up and down)
    //private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the camera transform
        cameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for right mouse button down to start panning
        if (Input.GetMouseButtonDown(1))
        {
            isPanning = true;
            panStartPosition = Input.mousePosition;
        }

        // Check for right mouse button up to stop panning
        if (Input.GetMouseButtonUp(1))
        {
            isPanning = false;
        }

        // Check for panning and move camera accordingly
        if (isPanning)
        {
            Vector3 panCurrentPosition = Input.mousePosition;
            Vector3 panOffset = panCurrentPosition - panStartPosition;
            panOffset = new Vector3(panOffset.x, 0f, panOffset.y);
            cameraTransform.Translate(panOffset * panSpeed * Time.deltaTime);
            panStartPosition = panCurrentPosition;
        }

        //// Get mouse input
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //Debug.Log(mouseY);
        //// Rotate camera horizontally
        //cameraTransform.Rotate(Vector3.up * mouseX);
        ////cameraTransform.Rotate(Vector3.left * mouseY);
        //// Rotate camera vertically
        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}