using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class BoundryBehaviour : MonoBehaviour
{
    public enum Side { Right = 0, Left = 1};

    public Side side;

    [SerializeField] private BoundriesConfigs boundriesConfigs;

    [SerializeField] private Rigidbody2D ballRB;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!ballRB)
        {
            Debug.Log("ballRB == null");
        }

        Vector2 forceDirection = new Vector2(0, 0);

        if (side == Side.Left)
        {
            forceDirection = Vector2.right;
        }
        else if(side == Side.Right)
        {
            forceDirection = Vector2.left;
        }

        ballRB.AddForce(forceDirection * boundriesConfigs.reppelForce,
                ForceMode2D.Impulse);
    }
}
