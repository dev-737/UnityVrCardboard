using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    public float amplitude = 0.5f;  // How high it goes up and down
    public float frequency = 1f;    // Speed of the levitation

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    void TiltInteract()
    {
        // Calculate the new Y position using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;

        // Apply the new position to the object
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
