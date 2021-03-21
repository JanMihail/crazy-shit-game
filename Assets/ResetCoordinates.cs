using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCoordinates : MonoBehaviour
{

    private Transform[] bones;

    // Start is called before the first frame update
    void Start()
    {
        bones = this.GetComponentsInChildren<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        foreach (Transform bone in bones)
        {
            Vector3 pos = bone.position;
            pos.z = 0;
            bone.position = pos;
            /*
            Vector3 currentRotation = bone.rotation.eulerAngles;
            currentRotation.x = 0.0f;
            currentRotation.y = 0.0f;

            bone.rotation = Quaternion.Euler(currentRotation);*/
        }
    }
}
