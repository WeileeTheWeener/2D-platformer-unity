using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowerComponent : MonoBehaviour
{
    [SerializeField] private Vector3 cameraOffset;
    [SerializeField] private float transitionSpeed;

    void FollowObject()
    {
        Vector2 newCameraPosition = Vector2.Lerp(Camera.main.transform.position,
            transform.position + cameraOffset,
            transitionSpeed);
        Camera.main.transform.position = new Vector3(newCameraPosition.x,
            newCameraPosition.y, 
            Camera.main.transform.position.z);

    }
    void FixedUpdate()
    {
        FollowObject();
    }
}
