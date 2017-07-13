using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ShowAchievements : MonoBehaviour {

	public string leaderboard;

	void Start() {

		GooglePlayGames.PlayGamesPlatform.Activate ();
		PlayGamesPlatform.DebugLogEnabled = true;

	}

	public void showAchievements() {

		Social.localUser.Authenticate ((bool success) =>
			{
				if (success) {
					Debug.Log ("Login Sucess");
				} else {
					Debug.Log ("Login failed");
				}
			});
		//Show achievements
		if (Social.localUser.authenticated) {
			Social.ShowAchievementsUI ();
		}

	}
}