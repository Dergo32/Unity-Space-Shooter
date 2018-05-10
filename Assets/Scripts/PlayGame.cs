using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
		SceneManager.LoadScene ("Level01", LoadSceneMode.Single);

	}
}
