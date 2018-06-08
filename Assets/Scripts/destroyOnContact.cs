using System.Collections;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy" || other.tag == "Environment") {
		
			return;
		
		}
		//create explosion effects
		Instantiate (explosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}

		//delete affected objects
		Destroy (other.gameObject);		//order doesn't matter
		Destroy (gameObject);
	}

}
