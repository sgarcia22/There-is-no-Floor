using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MuteSound : MonoBehaviour {

	private Toggle toggle;
	private AudioSource song;
	public bool toggleOn;

	public void muteSong () {

		song = GetComponent<AudioSource> ();
		toggle = GameObject.FindGameObjectWithTag ("Toggle_Song").GetComponent<Toggle> ();

		if (toggle.isOn) {
			toggleOn = true;
			song.mute = true;
			song.Stop ();
		} else {
			toggleOn = false;
			song.mute = false;
			song.Play ();
		}

	}


}
