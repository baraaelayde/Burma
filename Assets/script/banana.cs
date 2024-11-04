using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
    int Multiply(int a,int b)
    {
        return a*b ;
    }
    // Start is called before the first frame update
    void Start()
    {
        int number = 5;
        for (int i = 1;i <= 10;i++)
        {
             int result = Multiply(i,number);
             Debug.Log(number + "*" + i + "=" + result);
        }
    }
}

   
