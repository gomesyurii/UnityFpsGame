using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFloating : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float floatSpeed = 1.2f;
    public float floatHeight = 0.5f;

    private Vector3 originalPosition;
    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));

        float newY = originalPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
 