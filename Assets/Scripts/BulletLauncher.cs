using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public float force = 100.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.AddForce(transform.forward * force, ForceMode.VelocityChange);
        }
    }
}
