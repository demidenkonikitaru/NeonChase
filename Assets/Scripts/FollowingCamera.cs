using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;
    [SerializeField] private CameraConfigs cameraConfigs;

    void Start()
    {

    }

    void Update()
    {
        if (!targetToFollow)
        {
            Debug.Log("targetToFollow == null");
        }
        else
        {            
            MoveCameraUp();
        }
    }

    private void MoveCameraUp()
    {
        if (targetToFollow.position.y <
            transform.position.y + cameraConfigs.distanceToTargetY)
            return;

        transform.position =
            new Vector3(transform.position.x,
            targetToFollow.position.y - cameraConfigs.distanceToTargetY,
            transform.position.z);

    }
}
