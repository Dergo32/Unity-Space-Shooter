using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeDestroy : MonoBehaviour {

	public float destroyTimer;

	void Start(){
	
		Destroy (gameObject, destroyTimer);	//destroy once time is up
	
	}

}
