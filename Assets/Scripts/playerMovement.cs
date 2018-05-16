using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody playerBody;
	public Transform playerShip;
	public Transform playerCamera;
	public bool freezeRotation;

	public float minBoundX, maxBoundX, minBoundZ, maxBoundZ;	//player boundaries

	public float slowSpeed;				//speed by which player slows down
 	public float forceForward = 200f;	//game forces player forward constantly
	public float forwardForce = 200f;	//player can go faster if desired
	public float sidewaysForce = 1000f;	//player can fly to the sides of the screen

	// Use this for initialization
	void Start () {
		playerBody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W)) {		//player can go forward faster
			
			playerBody.AddForce (0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

			if (playerShip.position.z >= playerCamera.position.z + maxBoundZ) {
			
				playerShip.position = new Vector3 (playerShip.position.x, playerShip.position.y,playerCamera.position.z + maxBoundZ);
			
			}
		}

		if (Input.GetKey (KeyCode.A)) {		//player can go to the left

			playerBody.AddForce (-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);

			if (playerShip.position.x <= playerCamera.position.x + minBoundX) {

				playerShip.position = new Vector3 (playerCamera.position.x + minBoundX, playerShip.position.y,playerShip.position.z);

			}

		}

		if (Input.GetKey (KeyCode.D)) {		//player can go to the right

			playerBody.AddForce (sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);

			if (playerShip.position.x >= playerCamera.position.x + maxBoundX) {

				playerShip.position = new Vector3 (playerCamera.position.x + maxBoundX, playerShip.position.y,playerShip.position.z);

			}

		}

		if (Input.GetKey (KeyCode.S)) {		//player can slow down
		
			playerBody.AddForce (0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);

			if (playerShip.position.z <= playerCamera.position.z + minBoundZ) {

				playerShip.position = new Vector3 (playerShip.position.x, playerShip.position.y,playerCamera.position.z + minBoundZ);

			}

		}

		if (Input.GetKey (KeyCode.LeftShift)) {		//player can slow to a stop

			playerBody.velocity = playerBody.velocity * slowSpeed;		//make sure slowSpeed is a decimal between 1 and 0 when adjusting values

		}
	}
}
