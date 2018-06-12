﻿using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Transform camera;
	public Vector3 spawnValues;
	public int hazardCounter;
	public float wait;
	public float startWait;
	public float waitBetweenWaves;

	void Start () {
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
}