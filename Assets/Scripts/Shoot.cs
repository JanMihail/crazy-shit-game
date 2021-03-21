using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform bulletStartPoint;
    public float bulletForce = 100.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bullet = Instantiate(bulletPrefab, bulletStartPoint.position, Quaternion.identity);
            bullet.AddForce(bulletStartPoint.forward * bulletForce, ForceMode.VelocityChange);
            Destroy(bullet.gameObject, 20);
        }
    }
}
