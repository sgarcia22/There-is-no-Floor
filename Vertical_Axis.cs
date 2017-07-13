using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical_Axis : MonoBehaviour {

	// Prevent Phone from being turned sideways
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}

}
