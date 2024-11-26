using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18{
public class Character1 {
    public string name;  
    private int health;   
    protected Position position;  
    public int Health {
        get { return health; }
        set {
            if (value < 0){
                health = 0;
            }
            else if (value > 100){
                health = 100;
            }
            else{
                health = value;
            }
        }
        }
        public Character1(string name, int health, Position position) {
            this.name = name;
            Health = health;  
            this.position = position;
        }
        public Character1() : this("No name", 100, new Position(0, 0, 0)) { }
        public virtual void DisplayInfo() {
            Debug.Log("Name : " + name);
            Debug.Log("Health : " + Health);
            position.PrintPosition();  
        }
        public void Attack(int damage, Character1 target)
        {
            target.Health -= damage;
        }

        public void Attack(int damage, Character1 target, string attackType)
        {
            Attack(damage, target);
            Debug.Log("Attack Type : " +attackType);
        }
}
}