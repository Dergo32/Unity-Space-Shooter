using System.Collections;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameObject GameManager;

	void Awake(){
	
		GameManager = GameObject.Find ("GameManager");
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy" || other.tag == "Environment") {
		
			return;
		
		}
		//create explosion effects
		Instantiate (explosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
			
		//GameManager.addToScore (scoreValue);
		GameManager.GetComponent<GameController>().addToScore(scoreValue);	//use this to call script
		Destroy (other.gameObject);		//order doesn't matter
		Destroy (gameObject);
	}

}
