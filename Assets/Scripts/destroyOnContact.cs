using System.Collections;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
		
			return;
		
		}

		Destroy (other.gameObject);		//order doesn't matter
		Destroy (gameObject);
	}

}
