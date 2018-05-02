using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Transform player;

	public float smoothSpeed = 10f;

	public Vector3 Offset;

	void FixedUpdate(){

		Vector3 targetPos = player.position + Offset;	//know where the camera needs to go, including with desired offset
		Vector3 smoothedPos = Vector3.Lerp (transform.position, targetPos, smoothSpeed*Time.deltaTime);	//apply smoothing (multiply by delta time so that speed is the same regardless of frame rate)
		transform.position = targetPos;		//make the camera go where it needs to go
	}

}