using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class BallBehaviour : MonoBehaviour
{

    [SerializeField] private BallConfigs ballConfigs;

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        if (!rb)
            rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(Vector2.up * ballConfigs.upForce, ForceMode2D.Impulse);
    }
}
