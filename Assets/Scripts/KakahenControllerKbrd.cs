using UnityEngine;

public class KakahenControllerKbrd : MonoBehaviour
{
    public Kakahen kakahen;

    private float moveHor;
    private float moveVert;
    private bool jump = false;

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

        if (jump)
        {
            jump = false;
            kakahen.jump();
        }
    }

    private void updateCoords()
    {
        moveHor = Input.GetAxisRaw("Horizontal");
        moveVert = Input.GetAxisRaw("Vertical");
        
        jump = Input.GetAxisRaw("Jump") > 0;
    }
}
