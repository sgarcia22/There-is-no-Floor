using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAudioObject : MonoBehaviour {

	private GameObject muteMainSong;
	private MuteSound scriptSound;
	private Toggle soundToggle;

	public void activateMuteFunction () {

		soundToggle = GetComponent<Toggle> ();
		//If there is no script currently attached to execute function
		if (muteMainSong == null) {
			
			muteMainSong = GameObject.FindGameObjectWithTag ("MainSong");
			muteMainSong.GetComponent<AudioSource> ();
			scriptSound = muteMainSong.GetComponent<MuteSound> ();
			scriptSound.muteSong ();
		
		} else {
			
			scriptSound = muteMainSong.GetComponent<MuteSound> ();
			scriptSound.muteSong ();

		}


	}

}
