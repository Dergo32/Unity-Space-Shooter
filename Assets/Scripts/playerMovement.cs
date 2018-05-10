using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody playerBody;
	public Transform playerShip;
	public bool freezeRotation;

	public float minBoundX, maxBoundX, minBoundZ, maxBoundZ;	//player boundaries

	public float forceForward = 200f;	//game forces player forward constantly
	public float forwardForce = 200f;	//player can go faster if desired
	public float sidewaysForce = 1000f;	//player can fly to the sides of the screen

	// Use this for initialization
	void Start () {
		playerBody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey ("w")) {		//player can go forward faster
			
			playerBody.AddForce (0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
			Mathf.Clamp (playerBody.position.z, minBoundZ, maxBoundZ);
		}

		if (Input.GetKey ("a")) {		//player can go to the left

			playerBody.AddForce (-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
			Mathf.Clamp (playerBody.position.x, minBoundX, maxBoundX);

		}

		if (Input.GetKey ("d")) {		//player can go to the right

			playerBody.AddForce (sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
			Mathf.Clamp (playerBody.position.x, minBoundX, maxBoundX);

		}
	}
}
