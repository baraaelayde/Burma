using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   public string name ;
   public int health ;
   public string Name {
    get{return name ;}
    set{name = value ;}
   }
   public int Health {
        get{return health; }
        set{
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value;
        }
    }
    public Character (string name , int health) {
        this.name = name ;
        this.health = health ;
    }
}
