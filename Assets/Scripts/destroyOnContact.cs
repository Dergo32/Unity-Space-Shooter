using System.Collections;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	public GameController GameManager;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy" || other.tag == "Environment") {
		
			return;
		
		}
		//create explosion effects
		Instantiate (explosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
			
		GameManager.addToScore (scoreValue);
		Destroy (other.gameObject);		//order doesn't matter
		Destroy (gameObject);
	}

}
