using UnityEngine;

public class KakahenControllerKbrd : MonoBehaviour
{
    public Kakahen kakahen;

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
        moveHor = Input.GetAxisRaw("Horizontal");
        moveVert = Input.GetAxisRaw("Vertical");
    }
}
