using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollScript : MonoBehaviour {

	public float tileSizeZ;
	public Transform backgroundTransform;
	public GameObject background;
	private Vector3 startPosition, endPosition;

	// Use this for initialization
	void Start () {

		startPosition = backgroundTransform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		tileSizeZ = GetComponent<Collider> ().bounds.size.z;
		
	}
}
