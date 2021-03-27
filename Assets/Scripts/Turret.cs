using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Turret : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSensitivity = 1.5f;

    [Range(-90f, 90f)]
    public float rotateAngleMin = -90f;

    [Range(-90f, 90f)]
    public float rotateAngleMax = 90f;

    public Rigidbody bulletPrefab;
    public Transform bulletShootPoint;
    public float bulletForce = 100f;

    private float leftRightAngle = 0.0f;
    private float upDownAngle = 0.0f;
    private bool isValid = false;
    

    void Start()
    {
        validate();
    }

    private void validate()
    {
        isValid = false;

        if (rotateAngleMin > rotateAngleMax)
        {
            
            throw new System.Exception(string.Format("rotateAngleMin {0:F2} > rotateAngleMax {1:F2}", rotateAngleMin, rotateAngleMax));
        }

        isValid = true;
    }

    public void move(float horizontal, float vertical)
    {
        move(horizontal, vertical, Time.deltaTime);
    }

    public void move(float horizontal, float vertical, float multiplicity)
    {
        if (!isValid) { return; }

        float hor = horizontal * moveSpeed;
        float vert = vertical * moveSpeed;

        Vector3 direction = new Vector3(hor, 0, vert);

        transform.Translate(direction.normalized * moveSpeed * multiplicity);
    }

    public void rotate(float horizontal, float vertical)
    {
        if (!isValid) { return; }

        leftRightAngle += horizontal * rotateSensitivity;
        upDownAngle -= vertical * rotateSensitivity;

        leftRightAngle %= 360.0f;
        upDownAngle = Mathf.Clamp(upDownAngle, rotateAngleMin, rotateAngleMax);

        transform.eulerAngles = new Vector3(upDownAngle, leftRightAngle);
    }

    public void fire()
    {
        Rigidbody bullet = Instantiate(bulletPrefab, bulletShootPoint.position, bulletShootPoint.rotation);
        bullet.AddForce(bulletShootPoint.forward * bulletForce, ForceMode.VelocityChange);
    }
}
