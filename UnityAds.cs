using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour {


	public void showAd() {
		if (Advertisement.IsReady ())
			Advertisement.Show ();
	}

}
