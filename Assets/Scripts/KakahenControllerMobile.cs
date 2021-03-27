using UnityEngine;

public class KakahenControllerMobile : MonoBehaviour
{
    public Kakahen kakahen;
    public VariableJoystick joystickMove;

    private float moveHor;
    private float moveVert;

    void Start()
    {
        updateCoords();
    }

    void Update()
    {
        updateCoords();
    }

    void FixedUpdate()
    {
        kakahen.move(moveHor, moveVert);
    }

    private void updateCoords()
    {
        moveHor = joystickMove.Horizontal;
        moveVert = joystickMove.Vertical;
    }
}
