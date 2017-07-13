using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	//Used to prevent the music from being destroying in the scene changes 
	void Start () {
		DontDestroyOnLoad (gameObject);
	}

}
