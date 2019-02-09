using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlatform : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;
    [SerializeField] private PlatformConfigs platformConfigs;

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
            MoveUp();
        }
    }

    private void MoveUp()
    {
        if (targetToFollow.position.y <
            transform.position.y + platformConfigs.distanceToTargetY)
            return;

        transform.position =
            new Vector2(transform.position.x,
            targetToFollow.position.y - platformConfigs.distanceToTargetY);

    }
}
