using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Debug.Log(string.Format("x = {0}, y = {1}", x, y));

        this.GetComponent<Rigidbody>().AddForce(new Vector3(x, 0, y) * speed * Time.deltaTime);
        //this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jump * jumpSpeed), ForceMode.Impulse);
    }
}
