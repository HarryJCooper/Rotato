using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePotato : MonoBehaviour
{
    public float rollTorqueAmount = 20f; // Adjustable torque amount for rotation
    public float rotateTorqueAmount = 10f; // Adjustable torque amount for rotation
    public float moveForce = 10f; // Adjustable force amount for movement
    public float gravity;  // Offset from the target object
    public bool useTorque;

    void Start() => Physics.gravity = new Vector3(0, gravity, 0);

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            MoveDirectly(transform.forward * moveForce); // Rotate forward
            ApplyTorque(transform.right * -rollTorqueAmount); // Rotate forward
        } 
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            MoveDirectly(transform.forward * -moveForce); // Rotate backward
            ApplyTorque(transform.right * rollTorqueAmount);
        } 
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            MoveDirectly(transform.right * -moveForce); // Rotate left
            ApplyTorque(Vector3.up * -rotateTorqueAmount); // Rotate left
        } 
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            MoveDirectly(transform.right * moveForce); // Rotate right
            ApplyTorque(Vector3.up * rotateTorqueAmount); // Rotate right
        } 
    }

    void ApplyTorque(Vector3 torque)
    {
        if (useTorque) return;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(torque);
    }

    void MoveDirectly(Vector3 force)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(force);
    }
}
