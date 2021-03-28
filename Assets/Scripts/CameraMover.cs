using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform cam;

    void Update()
    {
        Vector3 curPos = cam.position;
        curPos.x = transform.position.x;
        cam.position = curPos;
    }
}
