using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]

public class scrollScript : MonoBehaviour {

	public float offsetZ = 2f; //offset to make sure next tile is there before camera
	public bool nextTileIsThere = false; //Check to see if next tile needs to be created
	private float spriteHeight = 0f;	//the height of the background

	//references
	private Camera cam;
	private Transform backgroundTransform;

	//set up references
	void Awake(){
	
		cam = Camera.main;
		backgroundTransform = transform;
	
	}

	void Start () {
		SpriteRenderer renderer = GetComponent<SpriteRenderer> ();	//get renderer
		spriteHeight = renderer.sprite.bounds.size.z;	//get height
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//what to do if current tile needs another tile
		if (nextTileIsThere == false) {
		
			float camVerticalExtent = cam.orthographicSize * Screen.height / Screen.width;
		
		}

	}
}
