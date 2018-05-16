using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	public void loadnextlevel()
	{
<<<<<<< HEAD

=======
>>>>>>> 0e9038341d093285a59088b2838aee31288058ae
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
