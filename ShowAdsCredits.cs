using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAdsCredits : MonoBehaviour {

	private float currentTime = 0;
	private int intCurrentTime = 0;

	private int playAtSeconds = 5;

	private int paidRemoveAds;

	private UnityAds playAd;
	// Update is called once per frame
	void Start() {
		paidRemoveAds = PlayerPrefs.GetInt ("RemoveAds");
	}

	void Update () {

		currentTime = Time.timeSinceLevelLoad;
		intCurrentTime = (int)currentTime;
		if (currentTime == 5 && paidRemoveAds == 0) {
			Debug.Log ("Showing Ad");
			playAd.showAd ();
			playAtSeconds += 25;
		}
		if (playAtSeconds != 5 && (intCurrentTime == playAtSeconds) && paidRemoveAds == 0) {
			Debug.Log ("Showing Ad");
			playAd.showAd ();
		}

	}
}
