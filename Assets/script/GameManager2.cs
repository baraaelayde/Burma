using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Player2 player = new Player2("Subhi", 100);
        Enemy enemy = new Enemy("Zarifeh", 100);
        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");
        player.Heal(20); 
        enemy.Attack(player, 30); 
        Debug.Log($"After actions: {player.Name}, Health: {player.Health}");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
