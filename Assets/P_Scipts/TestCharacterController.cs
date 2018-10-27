using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour {


    [SerializeField]
    float moveSpeed = 2;
    Rigidbody rb;
    Vector3 forward, right;

	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();   
        forward = Camera.main.transform.forward;
        forward.y = 0;
        //forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Push();
        }
    
	}

    void Push()
    {
       //Vector3 dir = new Vector3(Input.GetAxis("h_move"), 0, Input.GetAxis("v_move"));


        Vector3 rightMove = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMove = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        Debug.Log(upMove + "upmove");
        Vector3 heading = Vector3.Normalize(rightMove + upMove) * moveSpeed;

        //determines rotation
        transform.forward = heading;

        //make movement
        rb.AddForce(upMove);
        transform.position += heading;
        //transform.position += upMove;


    }
}
