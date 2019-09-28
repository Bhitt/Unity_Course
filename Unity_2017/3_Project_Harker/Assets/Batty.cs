using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batty : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Thrusting
            rigidBody.AddRelativeForce(Vector3.up);   //using Vector3
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Rotate Left

        }else if (Input.GetKey(KeyCode.D))
        {
            //Rotate Right
        }
    }
}
