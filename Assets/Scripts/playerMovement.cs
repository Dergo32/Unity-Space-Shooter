﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody playerBody;
	public Transform playerShip;
	public Transform playerCamera;
	public bool freezeRotation;

	public float minBoundX, maxBoundX, minBoundZ, maxBoundZ;	//player boundaries
	public float minCamBoundX, maxCamBoundX, minCamBoundZ, maxCamBoundZ;

	public float slowSpeed;				//speed by which player slows down
	public float forwardForce = 200f;	//player can go faster if desired
	public float sidewaysForce = 1000f;	//player can fly to the sides of the screen

	public GameObject laser;
	public Transform laserSpawn;

	public GameObject PauseScreen;

	// Use this for initialization
	void Start () {
		playerBody.freezeRotation = true;
	}

	void Update(){

		if (Input.GetKey (KeyCode.Space)) {
			Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
		}
	}

	// Update is called once per frame
	void FixedUpdate () {


		minCamBoundX = playerCamera.position.x - minBoundX;
		maxCamBoundX = playerCamera.position.x + maxBoundX;
		minCamBoundZ = playerCamera.position.z - minBoundZ;
		maxCamBoundZ = playerCamera.position.z + maxBoundZ;

		if (Input.GetKey (KeyCode.W)) {		//player can go forward faster
			
			playerBody.AddForce (0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetKey (KeyCode.A)) {		//player can go to the left

			playerBody.AddForce (-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
		}

		if (Input.GetKey (KeyCode.D)) {		//player can go to the right

			playerBody.AddForce (sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);

		}

		if (Input.GetKey (KeyCode.S)) {		//player can slow down
		
			playerBody.AddForce (0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetKey (KeyCode.LeftShift)) {		//player can slow to a stop

			playerBody.velocity = playerBody.velocity * slowSpeed;		//make sure slowSpeed is a decimal between 1 and 0 when adjusting values

		}

		if (Input.GetKey (KeyCode.Escape)) {		//player STOPS TIME AND A UI POPS UP

			PauseScreen.active = true; 		//make sure pause panel pops up when player presses escape
			playerBody.velocity = Vector3.zero;
		}


		playerRestrict ();

	}

	private void playerRestrict(){
	
		playerBody.position = new Vector3 (
			Mathf.Clamp (playerBody.position.x, minCamBoundX, maxCamBoundX),
			0.0f,
			Mathf.Clamp (playerBody.position.z, minCamBoundZ, maxCamBoundZ)
		);
	}
}
	
