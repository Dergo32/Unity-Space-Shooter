using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
<<<<<<< HEAD
		SceneManager.LoadScene ("Level01", LoadSceneMode.Single);
=======
		SceneManager.LoadScene(2);	//use index in build settings
>>>>>>> 18b6b13fdcbd7bd3ba771c4f55e0178d2d6c5fac

	}

	public GameObject settingspanel;
	public GameObject leaderboardpanel;

	public void OpenSettings()
	{
		settingspanel.active = true;
	}

	public void OpenLeaderBoard()
	{
		leaderboardpanel.active = true;
	}

	public void backfromsettings()
	{
		settingspanel.active = false;
	}

	public void backfromleaderboard()
	{
		leaderboardpanel.active = false;
	}
}
