using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Transform camera;
	public Vector3 spawnValues;
	public int hazardCounter;
	public float wait;
	public float startWait;
	public float waitBetweenWaves;

	public Text scoreText;
	public int score;

	void Start () {
		score = 0;
		scoreUpdate ();
		StartCoroutine (spawnWaves ());
	}

	//coroutine instead of function
	IEnumerator spawnWaves(){

		yield return new WaitForSeconds (startWait);	//wait before starting to spawn

		while (true) {		//loop goes on forever
			
			for (int i = 0; i < hazardCounter; i++) {
				Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z + camera.position.z);
				Quaternion spawnRotate = Quaternion.identity;
				Instantiate (hazard, spawnPos, spawnRotate);
				yield return new WaitForSeconds (wait);		//wait before spawning each hazard
			}

		}
	}

	public void addToScore(int newScore){
	
		score += newScore;
		scoreUpdate ();
	
	}

	void scoreUpdate(){

		scoreText.text = score.ToString();

	}
}
