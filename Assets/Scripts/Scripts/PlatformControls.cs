using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Summary: Contains controls for main platform controolled by player. */

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformControls : MonoBehaviour
{

    [SerializeField] private PlatformConfigs platformConfigs;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform targetToFollow;

    private Vector2 moveInput;

    private Vector2 moveVelocity;

    void Start()
    {
        if (!rb)
            rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput.normalized * platformConfigs.movementSpeed;
    }

    private void FixedUpdate()
    {
        PlatformMovement();
    }

    private void PlatformMovement()
    {
        /*if (targetToFollow.position.y <
            transform.position.y + platformConfigs.distanceToTargetY)
        {
            rb.position = new Vector2(
            Mathf.Clamp(rb.position.x,
            -platformConfigs.xMoveRestriction, platformConfigs.xMoveRestriction),
            rb.position.y);

            transform.position =
            new Vector2(rb.position.x + moveVelocity.x * Time.fixedDeltaTime,
            rb.position.y);
        }
        else
        {
            rb.position = new Vector2(
            Mathf.Clamp(rb.position.x,
            -platformConfigs.xMoveRestriction, platformConfigs.xMoveRestriction),
            Mathf.Clamp(rb.position.y,
            targetToFollow.position.y - platformConfigs.distanceToTargetY,
            targetToFollow.position.y - platformConfigs.distanceToTargetY));

            transform.position =
            new Vector2(rb.position.x + moveVelocity.x * Time.fixedDeltaTime,
            targetToFollow.position.y - platformConfigs.distanceToTargetY);

        }*/

        Vector2 clampedPosition = new Vector2(
            Mathf.Clamp(transform.localPosition.x,
            -platformConfigs.xMoveRestriction, platformConfigs.xMoveRestriction),
            transform.localPosition.y);

        transform.localPosition = clampedPosition;

        transform.localPosition =
        new Vector3(transform.localPosition.x + moveVelocity.x * Time.fixedDeltaTime,
        transform.localPosition.y, 10);
    }
}

