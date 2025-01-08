using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class KineticSculpure : MonoBehaviour
{
     float rotationSpeed = 50f ; 
    void Start()
    {
    }
    void Update()
    {
       transform.Rotate(0, rotationSpeed * Time.deltaTime, 0) ;
    }
}
