using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRed : Balls
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        base.fuerza = 0.5f;

    }

    private void Update()
    {
        Jump();
    }

    public override void Jump() //POLYMORPHISM
    {
        rb.AddForce(Vector3.up * base.fuerza);

    }
}
