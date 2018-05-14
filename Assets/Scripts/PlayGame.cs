using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
		SceneManager.LoadScene ("Level01", LoadSceneMode.Single);

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
