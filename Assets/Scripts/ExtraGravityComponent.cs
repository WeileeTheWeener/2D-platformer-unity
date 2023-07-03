using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraGravityComponent : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float extraGravity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void ApplyExtraGravity()
    {
        if (rb.velocity.y < 0)
        {
            rb.AddForce(Vector2.down * extraGravity, ForceMode2D.Force);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ApplyExtraGravity();

    }
}