using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerRigidBody;
    public float playerSpeed = 30f;
    public float jumpForce = 10f;
    public float rotationSpeed = 0.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Movement
        if (Input.GetAxis("Vertical") > 0.1f)
        {
            playerRigidBody.AddRelativeForce(0, 0, playerSpeed);
        } else if (Input.GetAxis("Vertical") < -0.1f)
        {
            playerRigidBody.AddRelativeForce(0, 0, -playerSpeed);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            playerRigidBody.AddRelativeForce(playerSpeed, 0, 0);
        } else if (Input.GetAxis("Horizontal") < -0.1f)
        {
            playerRigidBody.AddRelativeForce(-playerSpeed, 0, 0);
        }

        //Jump
        if (Input.GetKey("space"))
        {
            playerRigidBody.AddForce(0 , jumpForce, 0);
        }

        //Gazedirection
        if (Input.GetKey("e"))
        {
            playerRigidBody.angularVelocity = Vector3.zero;
            playerRigidBody.GetComponentInParent<Transform>().Rotate(0, rotationSpeed, 0);
        } else if (Input.GetKey("q"))
        {
            playerRigidBody.angularVelocity = Vector3.zero;
            playerRigidBody.GetComponentInParent<Transform>().Rotate(0, -rotationSpeed, 0);
        }
	}
}
