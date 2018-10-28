using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAssignment : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    public PlayerController player3;
    public PlayerController player4;
    private void Start()
    {
        StartCoroutine(AssignThem());
    }


    IEnumerator AssignThem()
    {
        yield return new WaitForSeconds(2);
        assign();
      

    }
   public void assign()
    {
        player1.playerIndex = XInputDotNetPure.PlayerIndex.One;
        player2.playerIndex = XInputDotNetPure.PlayerIndex.Two;
        player3.playerIndex = XInputDotNetPure.PlayerIndex.Three;
        player4.playerIndex = XInputDotNetPure.PlayerIndex.Four;

    }
	
}
