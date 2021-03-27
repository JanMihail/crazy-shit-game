using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTimeSeconds = 20f;

    void Start()
    {
        Destroy(gameObject, lifeTimeSeconds);
    }
}
