using UnityEngine;

public class Kakahen : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 5.0f;
    public Rigidbody baseBone;

    public void move(float horizontal, float vertical)
    {
        baseBone.AddTorque(new Vector3(0, 0, -horizontal) * moveSpeed, ForceMode.VelocityChange);
    }

    public void jump()
    {
        baseBone.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }
}
