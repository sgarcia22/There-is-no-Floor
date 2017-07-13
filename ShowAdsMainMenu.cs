using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAdsMainMenu : MonoBehaviour {

	private float currentTime = 0;
	private int intCurrentTime = 0;
	//TODO: CHANGE TO 60 
	private int playAtSeconds = 60;
	public const int secondsToPlayAt = 60;

	private int paidRemoveAds;

	void Update () {
		
		currentTime = Time.timeSinceLevelLoad;
		intCurrentTime = (int)currentTime;

		if (intCurrentTime == secondsToPlayAt) {
			Debug.Log ("GONNA Showing Ad");
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
