using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Transform player;

	public float smoothSpeed = 10f;

	public float scrollSpeed = 1f;

	public Vector3 Offset;

	// Use this for initialization
	void Start () {

		Vector3 targetPos = player.position + Offset;	//know where the camera needs to go, including with desired offset
		Vector3 smoothedPos = Vector3.Lerp (transform.position, targetPos, smoothSpeed * Time.deltaTime);	//apply smoothing (multiply by delta time so that speed is the same regardless of frame rate)
		transform.position = targetPos;		//make the camera go where it needs to go
	
	}

	//Updates once per frame
	void FixedUpdate(){

		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + scrollSpeed);	//make camera go forward at certain speed

	}

}