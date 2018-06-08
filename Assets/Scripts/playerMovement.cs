using System.Collections;
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

	public float fireRate;
	private float nextFire;

	public GameObject laser;
	public Transform laserSpawn;

	public GameObject PauseScreen;

	// Use this for initialization
	void Start () {
		playerBody.freezeRotation = true;
	}

	void Update(){

		if (Input.GetButton("Fire") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
		}

	}

	void FixedUpdate () {


		minCamBoundX = playerCamera.position.x - minBoundX;
		maxCamBoundX = playerCamera.position.x + maxBoundX;
		minCamBoundZ = playerCamera.position.z - minBoundZ;
		maxCamBoundZ = playerCamera.position.z + maxBoundZ;

		if (Input.GetButton("Move Forward")) {		//player can go forward faster
			
			playerBody.AddForce (0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetButton("Move Left")) {		//player can go to the left

			playerBody.AddForce (-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
		}

		if (Input.GetButton("Move Right")) {		//player can go to the right

			playerBody.AddForce (sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);

		}

		if (Input.GetButton("Brake")) {		//player can slow down
		
			playerBody.AddForce (0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetButton("Stop Completely")) {		//player can slow to a stop

			playerBody.velocity = playerBody.velocity * slowSpeed;		//make sure slowSpeed is a decimal between 1 and 0 when adjusting values

		}

		if (Input.GetButton("Pause")) {		//player STOPS TIME AND A UI POPS UP

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
	
