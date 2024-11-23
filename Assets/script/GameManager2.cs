using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Player2 player = new Player2("Subhi",80);
        Enemy enemy = new Enemy("Zarifeh",70);
        Debug.Log("Player name is : "+player.Name+" Player health is : "+player.Health);
        Debug.Log("Enemy name is : "+enemy.Name+" Enemy health is : "+enemy.Health);
        player.Heal(10); 
        Debug.Log("Player Health is : "+player.Health);
        enemy.Attack(player, 100); 
        Debug.Log("Player Health is : "+player.Health); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
