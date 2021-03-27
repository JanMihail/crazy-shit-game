using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform camera;

    void Update()
    {
        Vector3 curPos = camera.position;
        curPos.x = transform.position.x;
        camera.position = curPos;
    }
}
