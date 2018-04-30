using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Transform player;

	public float smooth = 0.1f;

	public Vector3 Offset;

	void LateUpdate(){

		Vector3 targetPos = player.position + Offset;
		transform.position = player.position + Offset;
	}

}
