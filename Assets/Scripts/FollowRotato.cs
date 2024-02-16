using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotato : MonoBehaviour
{
    public Transform target; // The target GameObject to follow
    public Vector3 offsetPosition = new Vector3(0, 0, 0); // Offset from the target object

    void LateUpdate()
    {
        transform.position = target.position + target.TransformDirection(offsetPosition);

        // Copy the target's rotation but only apply the Y axis rotation to the camera
        float yRotation = target.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}