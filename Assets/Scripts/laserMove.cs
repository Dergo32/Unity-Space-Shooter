using System.Collections;
using UnityEngine;

public class laserMove : MonoBehaviour {

	public Rigidbody laserBody;	//reference to laser gameobject
	public float speed;			//how fast laser moves

	void Start(){
	
		laserBody.velocity = transform.forward * speed;	//move laser forward
	
	}

}
