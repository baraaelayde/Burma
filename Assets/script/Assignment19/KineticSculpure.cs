using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticSculpure : MonoBehaviour
{
        void Start()
    {
        
    }
    void Update()
    {
        float yNew = Mathf.Sin(Time.time );
        transform.rotation = Quaternion.Euler(new Vector3(0, yNew * 360f, 0));
    }
}
