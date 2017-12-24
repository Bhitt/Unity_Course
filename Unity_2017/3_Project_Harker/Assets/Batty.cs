﻿using System;
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
        if (Input.GetKey(KeyCode.Space))    // can thrust while rotating
        {
            //print("Thrusting");
            rigidBody.AddRelativeForce(Vector3.up);
            
        }

        if (Input.GetKey(KeyCode.A))        // rotate right or left
        {
            //print("Rotating Left");
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //print("Rotating Right");
            transform.Rotate(-Vector3.forward);
        }
    }
}