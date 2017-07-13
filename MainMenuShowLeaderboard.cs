using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class MainMenuShowLeaderboard : MonoBehaviour {

	public string leaderboard;

	void Start() {

		GooglePlayGames.PlayGamesPlatform.Activate ();
		PlayGamesPlatform.DebugLogEnabled = true;

	}

	public void showLeaderboard() {

		Social.localUser.Authenticate ((bool success) =>
			{
				if (success) {
					Debug.Log ("Login Sucess");
				} else {
					Debug.Log ("Login failed");
				}
			});
		
		if (Social.localUser.authenticated) {
			Social.ReportScore (PlayerPrefs.GetInt("Score5"), leaderboard, (bool success) =>
				{
					if (success) {
						Debug.Log ("Update Score Success");

					} else {
						Debug.Log ("Update Score Fail");
					}
				});
			//Show Leaderboard
			Social.ShowLeaderboardUI();
		}

	}
}
