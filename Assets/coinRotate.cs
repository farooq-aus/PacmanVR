using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotate : MonoBehaviour
{
    public float RotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(
            Vector3.forward * RotationSpeed * Time.deltaTime, Space.Self
        );
    }
}
