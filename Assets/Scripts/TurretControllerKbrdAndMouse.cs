using UnityEngine;

public class TurretControllerKbrdAndMouse : MonoBehaviour
{
    public Turret turret;

    private float moveHor;
    private float moveVert;
    private float rotHor;
    private float rotVert;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        updateCoords();
    }

    void Update()
    {
        updateCoords();
        turret.move(moveHor, moveVert);
        turret.rotate(rotHor, rotVert);
    }

    private void updateCoords()
    {
        moveHor = Input.GetAxis("WeaponHorizontal");
        moveVert = Input.GetAxis("WeaponVertical");

        rotHor = Input.GetAxis("Mouse X");
        rotVert = Input.GetAxis("Mouse Y");
    }
}
