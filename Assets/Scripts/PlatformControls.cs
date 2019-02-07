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
        rb.position = new Vector2
        (
            Mathf.Clamp(rb.position.x,
            - platformConfigs.xMoveRestriction, platformConfigs.xMoveRestriction),
           rb.position.y
        );

        //if(rb.position.x > - platformConfigs.xMoveRestriction && rb.position.x < platformConfigs.xMoveRestriction)
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        
    }
}
