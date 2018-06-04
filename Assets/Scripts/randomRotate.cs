using System.Collections;
using UnityEngine;

public class randomRotate : MonoBehaviour {

	public float tumble;
	public Rigidbody asteriod;

	// Use this for initialization
	void Start () {
		asteriod.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
