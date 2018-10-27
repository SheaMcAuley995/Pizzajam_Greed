using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectMotor : MonoBehaviour {

    public float movetime = 2f;
    public LayerMask mask;

    BoxCollider2D box;
    Rigidbody2D rb;
    float inverseMove;


    // Use this for initialization
    protected virtual void Start()
    {
       box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        inverseMove = (1 / movetime);

    }
    protected bool Move(int xDir, int yDir, out RaycastHit2D hit)
    {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xDir, yDir);

        box.enabled = false;
        hit = Physics2D.Linecast(start, end, mask);
        box.enabled = false;
        if (hit.transform == null)
        {
            StartCoroutine(smoothMove(end));
            return true;
        }
        return false;

    }

    protected virtual void AttemptMove<T>(int xDir, int yDir)
        where T : Component
    {
        RaycastHit2D hit;
        bool canMove = Move(xDir, yDir, out hit);
        if (hit.transform == null)
        {
            return;
        }
        T hitComponent = hit.transform.GetComponent<T>();
        if (!canMove && hitComponent != null)
        {
            OnCantMove(hitComponent);
        }
    }

    protected IEnumerator smoothMove(Vector3 end)
    {
        float sqrRemainingDist = (transform.position - end).sqrMagnitude;
        while (sqrRemainingDist> float.Epsilon)
        {
            Vector3 newPos = Vector3.MoveTowards(rb.position, end, inverseMove * Time.deltaTime);
            rb.MovePosition(newPos);
            sqrRemainingDist = (transform.position - end).sqrMagnitude;
            yield return null;

        }
    }
    protected abstract void OnCantMove<T>(T component)
        where T : Component;
}