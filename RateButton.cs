using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateButton : MonoBehaviour {


	public void openAndroidStore() {
	
		Application.OpenURL ("market://details?id=com.BlueBunnyGamer.ThereIsNoFloor");
	}
		
}
