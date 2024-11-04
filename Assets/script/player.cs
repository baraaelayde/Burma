using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player 
{
    public string playerName;
    public int health;
     private static int playerCount = 0;
    public void InitializePlayer(string name, int  initialHealth)
    {
        playerName = name;
        initialHealth = health;
        playerCount++;
    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(playerName + ":" + health);
    }
    public void Heal(bool fullRestore)
    {
        if(fullRestore)
        {
            health = 100;
            Debug.Log(playerName + ":" + health);
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
