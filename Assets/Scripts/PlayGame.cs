using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
		SceneManager.LoadScene ("Level01", LoadSceneMode.Single);

	}

	public void backtomainmenu()
	{
		SceneManager.LoadScene ("Main Menu", LoadSceneMode.Single);

	}

	public GameObject settingspanel;
	public GameObject leaderboardpanel;
	public GameObject shoppanel;
	public GameObject PauseMenu;
	public GameObject GameOverScreen;
	public GameObject[] DeathText;
	public static List <GameObject> DeathRandomText;

	public void OpenSettings()
	{
		settingspanel.active = true;
	}

	public void OpenLeaderBoard()
	{
		leaderboardpanel.active = true;
	}

	public void OpenShop()
	{
		shoppanel.active = true;
	}

	public void OpenPause()
	{
		PauseMenu.active = true;
	}

	public void backfromsettings()
	{
		settingspanel.active = false;
	}

	public void backfromleaderboard()
	{
		leaderboardpanel.active = false;
	}

	public void backfromshop()
	{
		shoppanel.active = false;
	}

	public void ExitPause()
	{
		PauseMenu.active = false;
	}

	public void GameOver()
	{
		GameOverScreen.active = true;
	}
}
