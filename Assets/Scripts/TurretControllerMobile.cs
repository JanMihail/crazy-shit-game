using UnityEngine;

public class TurretControllerMobile : MonoBehaviour
{
    public Turret turret;
    public VariableJoystick joystickMove;
    public VariableJoystick joystickRotate;

    private float moveHor;
    private float moveVert;
    private float rotHor;
    private float rotVert;

    void Start()
    {
        updateCoords();
    }

    void Update()
    {
        updateCoords();
        turret.move(moveHor, moveVert);
        turret.rotate(rotHor, rotVert);
    }

    public void fireClick()
    {
        turret.fire();
    }

    private void updateCoords()
    {
        moveHor = joystickMove.Horizontal;
        moveVert = joystickMove.Vertical;

        rotHor = joystickRotate.Horizontal;
        rotVert = joystickRotate.Vertical;
    }
}
