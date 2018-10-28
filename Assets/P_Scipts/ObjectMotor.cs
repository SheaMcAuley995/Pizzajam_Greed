using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMotor : MonoBehaviour {

    public float moveSpeed;
    BoxCollider2D box;
    Rigidbody2D rb;
    //public LayerMask mask;
  


    //public float movetime = 2f;



    //float inverseMove;


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

    }
    //protected bool Move(int xDir, int yDir, out RaycastHit2D hit)
    //{

    //    Vector2 start = transform.position;             //store start pos
    //    Vector2 end = start + new Vector2(xDir, yDir);  //calc end based on direc tion passed in when calling move

    //    box.enabled = false;                            //ray wont hit us
    //    hit = Physics2D.Linecast(start, end, mask);     //check collision
    //    box.enabled = false;
    //    if (hit.transform == null)
    //    {
    //        StartCoroutine(smoothMove(end));            //if we can move lets do it smooth
    //        return true;
    //    }
    //    return false;

    //}

    //protected virtual void AttemptMove<T>(int xDir, int yDir)
    //    where T : Component
    //{
    //    RaycastHit2D hit;
    //    bool canMove = Move(xDir, yDir, out hit);   
    //    if (hit.transform == null)
    //    {
    //        return;
    //    }
    //    T hitComponent = hit.transform.GetComponent<T>();
    //    if (!canMove && hitComponent != null)
    //    {
    //        OnCantMove(hitComponent);
    //    }
    //}

    //protected IEnumerator smoothMove(Vector3 end)
    //{
    //    float sqrRemainingDist = (transform.position - end).sqrMagnitude;
    //    while (sqrRemainingDist> float.Epsilon)
    //    {
    //        Vector3 newPos = Vector3.MoveTowards(rb.position, end, inverseMove * Time.deltaTime);
    //        rb.MovePosition(newPos);
    //        sqrRemainingDist = (transform.position - end).sqrMagnitude;
    //        yield return null;

    //    }
    //}
    //protected abstract void OnCantMove<T>(T component)
    //    where T : Component;
}