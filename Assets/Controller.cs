using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    private float playerSpeed = 100.0f;
    private Vector3 move;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        

        //if (Input.GetAxis("Jump") > 0)
        //{
        //    rb.AddForce(transform.up * playerSpeed, ForceMode.Force);
        //}
    }

    private void FixedUpdate()
    {
        move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        rb.AddForce(move * Time.fixedDeltaTime * playerSpeed, ForceMode.VelocityChange);
        // rb.AddTorque(new Vector3(0, 0, -2), ForceMode.Acceleration);
    }

    
}
