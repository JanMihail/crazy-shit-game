using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform obj;

    // Update is called once per frame
    void Update()
    {
        // transform.position.Set(obj.position.x, obj.position.y + 2, transform.position.z);

        transform.position = new Vector3(obj.position.x, (obj.position.y + 2), transform.position.z);
    }
}
