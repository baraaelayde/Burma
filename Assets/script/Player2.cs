using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{
    public Player2(string name, int health) : base(name, health) { }
    public void Heal(int amount) {
        Health += amount ; 
        Debug.Log($"{Name} healed by {amount}. Current health: {Health}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
