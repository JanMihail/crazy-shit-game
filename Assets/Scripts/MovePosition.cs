using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        float x = Input.GetAxis("WeaponHorizontal") * moveSpeed;
        float y = Input.GetAxis("WeaponVertical") * moveSpeed;

        Vector3 direction = new Vector3(x, 0, y);

        this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }
}
