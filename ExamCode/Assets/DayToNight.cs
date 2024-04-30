using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayToNight : MonoBehaviour
{
    public float rotationSpeed = .01f; 

    void Update()
    {
        
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        
        transform.Rotate(0, rotationThisFrame, 0);
    }
}
