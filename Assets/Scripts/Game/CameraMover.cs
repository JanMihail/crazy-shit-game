using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform obj;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(obj.position.x, obj.position.y, transform.position.z);
    }
}
