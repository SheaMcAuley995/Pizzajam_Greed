using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class PlayerController : MonoBehaviour
{

    bool playerIndexSet = false;
    [HideInInspector]
    public PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;
    ObjectMotor motor;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        motor = GetComponent<ObjectMotor>();
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        // Find a PlayerIndex, for a single player game
        // Will find the first controller that is connected ans use it
        if (!playerIndexSet || !prevState.IsConnected)
        {
            for (int i = 0; i < 4; ++i)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)i;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                {
                    Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                    playerIndex = testPlayerIndex;
                    playerIndexSet = true;
                }
            }
        }

        prevState = state;
        state = GamePad.GetState(playerIndex);
        Debug.Log(playerIndex + " = player index");
        
        
        motor.Move(state.ThumbSticks.Left.X, state.ThumbSticks.Left.Y);

    }



}
