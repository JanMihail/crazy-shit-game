using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;
    
    private float leftRightAngle = 0.0f;
    private float upDownAngle = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        leftRightAngle += Input.GetAxis("Mouse X") * mouseSensitivity;
        upDownAngle -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        leftRightAngle %= 360.0f;
        upDownAngle = Mathf.Clamp(upDownAngle, -90.0f, 90.0f);

        this.transform.eulerAngles = new Vector3(upDownAngle, leftRightAngle, 0.0f);
    }
}
