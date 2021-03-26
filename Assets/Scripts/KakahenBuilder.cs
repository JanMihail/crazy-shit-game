using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakahenBuilder : MonoBehaviour
{
    public GameObject kakahenPrefab;
    public int count;
    public float xMin = -40f;
    public float xMax = 40f;
    public float yMin = 10f;
    public float yMax = 57f;
    public float xStep = 9.5f;
    public float yStep = 1.5f;

    void Start()
    {
        float x = xMin;
        float y = yMin;

        for (int i = 0; i < count; ++i)
        {
            Instantiate(kakahenPrefab, new Vector3(x, y, 0), Quaternion.identity);

            x += xStep;
            if (x > xMax)
            {
                x = xMin;
                y += yStep;
            }

            if (y > yMax)
            {
                throw new System.Exception("Больше нет места для гавна. Укажите count поменьше");
            }
        }
    }
}
