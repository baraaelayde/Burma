using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public float deg = 0 ;
    public float angle = 1 ;
    public Vector3 scaleFactor = new Vector3(0.01f , 0.01f , 0.01f) ;
    void Start()
    {
        
    }
    void Update()
    {
        float mouseWhell = Input.GetAxis("Mouse ScrollWheel") ;
        if (Input.GetKey(KeyCode.RightArrow)) {
                deg += angle ;
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) {
                deg -= angle ;
            }
             if (Input.GetKey(KeyCode.KeypadPlus)) {
                transform.localScale += scaleFactor ;
            }
            else if (Input.GetKey(KeyCode.KeypadMinus)) {
                transform.localScale -= scaleFactor ;
            }
            transform.position += new Vector3(mouseWhell*20f , 0 , 0) ;
            transform.rotation = Quaternion.Euler(new Vector3(0 , deg , 0)) ;
    }
}
