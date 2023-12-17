using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallYellow : Balls
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        base.fuerza = -1.5f;

    }

    private void Update()
    {
        Jump();
    }

    public override void Jump()
    {
        rb.AddForce(Vector3.up * base.fuerza);

    }
}
