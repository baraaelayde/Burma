using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      string[] words = {"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird" };
      int counter = 0;
      string funnySentence="";
      while(counter<words.Length)
      {
        int randomNumber = Random.Range(0,words.Length);
        funnySentence += words[randomNumber]+" ";
        counter++;
      }
      Debug.Log(funnySentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
