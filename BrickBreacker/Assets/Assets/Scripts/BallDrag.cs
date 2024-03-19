using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallDrag : MonoBehaviour
{
    
    //Code made my ChatGpt
    //Just experimenting with what works before i officially do anything
    private Vector3 offset;
    private float zCoord;
    private bool isDragging = false;
    private Rigidbody rb;

    private void Start()
    {
        // Get the Rigidbody component attached to the object
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Make the Rigidbody kinematic initially
    }

    private void OnMouseDown()
    {
        // Calculate the offset between the object's position and the mouse cursor
        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPosition();

        // Disable kinematic so that physics will apply when the object is released
        rb.isKinematic = false;

        // Mark the object as being dragged
        isDragging = true;
    }

    private void OnMouseUp()
    {
        // Check if the object was being dragged
        if (isDragging)
        {
            // Calculate the velocity vector based on the mouse movement
            Vector3 velocity = (GetMouseWorldPosition() - (gameObject.transform.position - offset));

            // Apply the velocity as a force to the object to continue its movement
            rb.velocity = velocity;

            // Mark the object as no longer being dragged
            isDragging = false;
        }
    }

    private void Update()
    {
        // Check if the object is currently being dragged
        if (isDragging)
        {
            // Move the object to the new mouse position while maintaining the offset
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Get the current mouse position in world coordinates
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}




