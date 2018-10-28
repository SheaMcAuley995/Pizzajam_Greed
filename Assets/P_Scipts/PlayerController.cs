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
     SpriteRenderer spriteRender;
    [SerializeField]
    bool isLeft = false;

    // Use this for initialization
    void Start()
    {
        motor = GetComponent<ObjectMotor>();
        anim = GetComponent<Animator>();
        spriteRender = GetComponent<SpriteRenderer>();
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

        if (state.ThumbSticks.Left.X > 0)
        {
            isLeft = false;

        }
        else if(state.ThumbSticks.Left.X < 0)
        {
            isLeft = true;
        }
        if (isLeft)
        {
            spriteRender.flipX = true;
        }
        else if (!isLeft)
        { spriteRender.flipX = false; }

        if (state.ThumbSticks.Left.X != 0 || state.ThumbSticks.Left.Y != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        motor.Move(state.ThumbSticks.Left.X, state.ThumbSticks.Left.Y);

    }



}
