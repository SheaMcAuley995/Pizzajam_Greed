using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum playerNumber { player1, player2, player3, player4 }


public class ScoreManager : MonoBehaviour {

  
    public static ScoreManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of scoreManager Found");
            return;
        }

        instance = this;
    }

    public int Player1Score = 0;
    public int Player2Score = 0;
    public int Player3Score = 0;
    public int Player4Score = 0;

    public void addScore(playerNumber myPlayer, int score)
    {
        switch (myPlayer)
        {
            case playerNumber.player1:
                Player1Score += score;
                break;
            case playerNumber.player2:
                Player2Score += score;
                break;
            case playerNumber.player3:
                Player3Score += score;
                break;
            case playerNumber.player4:
                Player4Score += score;
                break;
        }  
    }
}
