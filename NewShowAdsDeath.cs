using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class NewShowAdsDeath : MonoBehaviour {

	private int scoreAmount;
	//Will store if user has died three times with a score under 20
	private int timesPlayed;
	//Will calculate time to see how long user is at scene
	private float currentTime = 0;
	private int intCurrentTime = 0;

	public const int secondsToPlayAt = 60;
	private int playAtSeconds = 60;

	void Start () {

		/*scoreAmount = PlayerPrefs.GetInt ("CurrentScore");

		if (scoreAmount >= 30) {
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
			} else {
				Debug.Log ("NOT Showing Ad");
			}
			PlayerPrefs.SetInt ("TimesDied", 0);
		}
		else {
			if (PlayerPrefs.GetInt("TimesDied") == 0)
				PlayerPrefs.SetInt ("TimesDied", 1);
			else
				PlayerPrefs.SetInt ("TimesDied", PlayerPrefs.GetInt("TimesDied") + 1);
		}

		timesPlayed = PlayerPrefs.GetInt ("TimesDied");

		if (timesPlayed == 4) {
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
			} else {
				Debug.Log ("NOT Showing Ad");
			}
			PlayerPrefs.SetInt ("TimesDied", 0);
		}*/

	}

	void Update () {
		currentTime = Time.timeSinceLevelLoad;
		intCurrentTime = (int)currentTime;

		if (intCurrentTime == secondsToPlayAt) {
			Debug.Log ("Showing Ad");
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
				playAtSeconds += secondsToPlayAt;
			} else {
				Debug.Log ("NOT Showing Ad");
			}
		}

		if (playAtSeconds != secondsToPlayAt && (intCurrentTime == playAtSeconds)) {
			Debug.Log ("Showing Ad");
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
				playAtSeconds += secondsToPlayAt;
			} else {
				Debug.Log ("NOT Showing Ad");
			}

		}

	}

}
