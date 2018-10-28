using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMotor : MonoBehaviour {

    public float moveSpeed;
    BoxCollider2D box;
    Rigidbody2D rb;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();


    }

    public void Move(float xDir, float yDir)
    {
        Vector2 dir = new Vector2(xDir, yDir) * Time.deltaTime * moveSpeed;

        rb.MovePosition((Vector2)transform.position + dir);
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            anim.SetBool("isWalking", true);
        }

    }
   
}