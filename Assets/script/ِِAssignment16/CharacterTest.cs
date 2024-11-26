using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18{
public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        Officer officer = new Officer("Subhi", 100, new Position());
        Soldier soldier = new Soldier("Ali", 100, new Position());
        Character1[] characters = new Character1[2];
        characters[0] = officer;
        characters[1] = soldier;
        for (int i = 0; i < characters.Length; i++){
                characters[i].DisplayInfo();
            }
         Debug.Log("Soldier's health before attack: " +soldier.Health);
         officer.Attack(20, soldier, "shooting");
         Debug.Log("Soldier's health after attack: " +soldier.Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}