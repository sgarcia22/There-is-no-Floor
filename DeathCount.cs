using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


public class DeathCount : MonoBehaviour {

	private int deathCount;

	void Start () {

		deathCount = PlayerPrefs.GetInt ("DeathCount");
		if (deathCount >= 10) {
			Social.ReportProgress (LeaderboardManager.achievement_10_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 10 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 10 Deaths Increment Failed");
				}
			});
		}

		if (deathCount >= 100) {
			Social.ReportProgress (LeaderboardManager.achievement_100_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 100 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 100 Deaths Increment Failed");
				}
			});
		}

		if (deathCount >= 1000) {
			Social.ReportProgress (LeaderboardManager.achievement_1000_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 1000 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 1000 Deaths Increment Failed");
				}
			});
		}


		//Increase Achievements 
		/*if (!(deathCount >= 10)) {
			PlayGamesPlatform.Instance.IncrementAchievement (LeaderboardManager.achievement_10_deaths, 1, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 10 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 10 Deaths Increment Failed");
				}
			});
		}


		if (!(deathCount >= 100)) {
			PlayGamesPlatform.Instance.IncrementAchievement (LeaderboardManager.achievement_100_deaths, 1, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 100 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 100 Deaths Increment Failed");
				}
			});
		}

		if (!(deathCount >= 1000)) {
			PlayGamesPlatform.Instance.IncrementAchievement (LeaderboardManager.achievement_1000_deaths, 1, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 1000 Deaths Increment Sucess");
				} else {
					Debug.Log ("Achievement 1000 Deaths Increment Failed");
				}
			});
		}

		//Post achievements when gaine without the incremental factor
		/*if (deathCount == 10) {
			Social.ReportProgress (LeaderboardManager.achievement_10_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 10 Deaths Sucess");
				} else {
					Debug.Log ("Achievement 10 Deaths Failed");
				}
			});
		} 
		if (deathCount == 100) {
			Social.ReportProgress (LeaderboardManager.achievement_100_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 100 Deaths Sucess");
				} else {
					Debug.Log ("Achievement 100 Deaths Failed");
				}
			});
		} 
		if (deathCount == 1000) {
			Social.ReportProgress (LeaderboardManager.achievement_1000_deaths, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("Achievement 1000 Deaths Sucess");
				} else {
					Debug.Log ("Achievement 1000 Deaths Failed");
				}
			});
		}*/

	}
	

}
