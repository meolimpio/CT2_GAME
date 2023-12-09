using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
