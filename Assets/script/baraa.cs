using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class baraa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int number =0;
       while(number<10)
       {
        int randomNumber = Random.Range(1,21);
        Debug.Log(randomNumber);
        number++;
       if(randomNumber==5)
       {
        continue;
       }
       if(randomNumber==15)
       {
        break;
       }
       }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
