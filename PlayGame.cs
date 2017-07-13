using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public Button startButton;


	public void startGame() {

		SceneManager.LoadScene (1);

	}
}
