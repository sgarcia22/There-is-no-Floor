using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

	private static MusicScript current = null;

	public static MusicScript Instance {
		get { 
			return current;
		}
	}

	void Start () {
		if (current != null && current != this) {
			Destroy (this.gameObject);
			return;
		} else {
			current = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}

}
