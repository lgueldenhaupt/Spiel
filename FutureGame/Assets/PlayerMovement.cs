using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerRigidBody;
    public float playerSpeed = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetAxis("Vertical") > 0.1f)
        {
            playerRigidBody.AddForce(0, 0, playerSpeed);
        } else if (Input.GetAxis("Vertical") < -0.1f)
        {
            playerRigidBody.AddForce(0, 0, -playerSpeed);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            playerRigidBody.AddForce(playerSpeed, 0, 0);
        } else if (Input.GetAxis("Horizontal") < -0.1f)
        {
            playerRigidBody.AddForce(-playerSpeed, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            playerRigidBody.AddForce(0 ,200f, 0);
        }
	}
}
