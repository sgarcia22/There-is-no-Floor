using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSoundOnWake : MonoBehaviour {

	private GameObject muteMainSong;
	private Toggle soundToggle;
	private MuteSound scriptSound;

	//This is to change the sprite when loading the menu based on the previous mute option
	void Start () {

		soundToggle = GetComponent<Toggle> ();
		muteMainSong = GameObject.FindGameObjectWithTag ("MainSong");
		muteMainSong.GetComponent<AudioSource> ();
		scriptSound = muteMainSong.GetComponent<MuteSound> ();

		if (scriptSound.toggleOn == true) {
			soundToggle.isOn = true;
		} else {
			soundToggle.isOn = false;
		}

	}

}
