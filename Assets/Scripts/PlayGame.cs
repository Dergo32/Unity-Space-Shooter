using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
		SceneManagement.LoadScene(Level01);

	}
}
