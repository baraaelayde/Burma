using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player player1 = new player();
        player player2 = new player();
        player1.InitializePlayer("Baraa", 50);
        player2.InitializePlayer("Noor", 30);
        player1.Heal(20);         
        player1.Heal(true);
        player2.Heal(10);
        player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
