using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum playerNumber { player1, player2, player3, player4 }


public class ScoreManager : MonoBehaviour {

   [SerializeField] TextMeshProUGUI timerGUI;
    float timer = 2;
    int highestScore;
    string winningPlayer;
    public static ScoreManager instance;

    [SerializeField] CharacterInventory p1_inv;
    [SerializeField] CharacterInventory p2_inv;
    [SerializeField] CharacterInventory p3_inv;
    [SerializeField] CharacterInventory p4_inv;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of scoreManager Found");
            return;
        }

        instance = this;
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            timerGUI.text = ((int)timer / 60).ToString() + ":" +((int)timer % 60).ToString();
        }

        if(timer < 0)
        {
            timer = 0;
            p1_inv.countScore();
            p2_inv.countScore();
            p3_inv.countScore();
            p4_inv.countScore();
            if(Player1Score > highestScore)
            {
                highestScore = Player1Score;
                winningPlayer = "Player 1";
            }
            if (Player2Score > highestScore)
            {
                highestScore = Player2Score;
                winningPlayer = "Player 2";
            }
            if (Player3Score > highestScore)
            {
                highestScore = Player3Score;
                winningPlayer = "Player 3";
            }
            if (Player4Score > highestScore)
            {
                highestScore = Player4Score;
                winningPlayer = "Player 4";
            }
            timerGUI.text = "WINNER: " + winningPlayer + " Score: " + highestScore.ToString();
        }
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
