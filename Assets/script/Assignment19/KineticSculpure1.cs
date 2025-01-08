using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticSculpure1 : MonoBehaviour
{
    float rotationSpeed = -50f ;
    void Start()
    { 
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0) ;
    }
}
