using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class FinalScore : MonoBehaviour {

	public Text finalScore;
	public string leaderboard;
	private int scoreAmount;
	private string scoreToString;


	void Start () {

		scoreAmount = PlayerPrefs.GetInt ("CurrentScore");
		scoreToString = scoreAmount.ToString ();

		finalScore.text = scoreToString;
		//Add Score Reached Achievement to Google Play Services upon Death
		if (scoreAmount >= 10) {
			Social.ReportProgress (LeaderboardManager.achievement_10_highscore, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("10 Highscore Success");

				} else {
					Debug.Log ("10 Highscore Fail");
				}
			});
		}
		if (scoreAmount >= 50) {
			Social.ReportProgress (LeaderboardManager.achievement_50_highscore, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("50 Highscore Success");

				} else {
					Debug.Log ("50 Highscore Fail");
				}
			});
		}
		if (scoreAmount >= 200) {
			Social.ReportProgress (LeaderboardManager.achievement_200_highscore, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("200 Highscore Success");

				} else {
					Debug.Log ("200 Highscore Fail");
				}
			});
		}
		if (scoreAmount >= 1000) {
			Social.ReportProgress (LeaderboardManager.achievement_1000_highscore, 100.0f, (bool success) => {
				if (success) {
					Debug.Log ("1000 Highscore Success");

				} else {
					Debug.Log ("1000 Highscore Fail");
				}
			});
		}

		//Add highest score to Leaderboard automatically
		if (scoreAmount > PlayerPrefs.GetInt ("Score5")) {
			OnAddScoreToLeaderBoard ();
		}

	}

	public void OnAddScoreToLeaderBoard ()
	{
		//Make sure the user is authenticated
		if (Social.localUser.authenticated) {
			Social.ReportScore (PlayerPrefs.GetInt("Score5"), leaderboard, (bool success) =>
				{
					if (success) {
						Debug.Log ("Update Score Success");

					} else {
						Debug.Log ("Update Score Fail");
					}
				});
		}
	}

}
