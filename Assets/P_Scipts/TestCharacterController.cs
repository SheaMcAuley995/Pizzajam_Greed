using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour {


    [SerializeField]
    float moveSpeed = 2;

    Vector3 forward, right;

	// Use this for initialization
	void Start () 
    {
        
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
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
       Vector3 dir = new Vector3(Input.GetAxis("h_move"), 0, Input.GetAxis("v_move"));


        Vector3 rightMove = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMove = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMove + upMove);

        //determines rotation
        transform.forward = heading;

        //make movement
        transform.position += heading;
        transform.position += upMove;


    }
}
