using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour {


    [SerializeField]
    float moveSpeed;

    Vector3 forward, right;

	// Use this for initialization
	void Start () {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

	}
	
	// Update is called once per frame
	void Update () {
        Push();
	}

    void Push()
    {
        
    }
}
