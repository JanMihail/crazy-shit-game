using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    private float playerSpeed = 1000.0f;
    private float jumpSpeed = 50.0f;
    private Vector3 move;
    private bool jump = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            
        }
    }

    private void FixedUpdate()
    {
        move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        //rb.AddForce(move * Time.fixedDeltaTime * playerSpeed, ForceMode.VelocityChange);
        rb.AddTorque(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal")) * playerSpeed, ForceMode.VelocityChange);

        if (jump)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            jump = false;
        }
    }

    
}
