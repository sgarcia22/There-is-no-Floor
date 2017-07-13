using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class MoveCharacter : MonoBehaviour {

	public GameObject player;

	private int screenWidth;
	private int screenHeight;
	private Vector3 playerPosition;
	private Touch touch;
	private bool tapping;
	private int moveBy;
	private int smooth = 10;

	public bool death = false;

	public Score score;

	private int scoreAmount;
	//Will store if user has died three times with a score under 20
	private int timesPlayed;

	void Start () {

		screenWidth = Camera.main.pixelWidth;
		screenHeight = Camera.main.pixelHeight;

		moveBy = screenWidth / 4;

		//Score is reset just in case
		score.resetScore ();

		//Debug.Log ("Playerpositon OG" + player.transform.position);
	}

	void Update () {


		playerPosition = Camera.main.WorldToScreenPoint (player.transform.position);

		playerPosition.z = 1;

		if (Input.touchCount == 1) {
			tapping = true;

			touch = Input.GetTouch (0); 

			if (touch.position.x >= (screenWidth / 2) && (touch.phase == TouchPhase.Began)) {
				StartCoroutine ("moveRight");
			} else if (touch.position.x < (screenWidth / 2) && (touch.phase == TouchPhase.Began)) {
				StartCoroutine ("moveLeft");
			}
				
			tapping = false;

		}

		//Debug.Log ("Player Position: " + playerPosition.x);

		playerPosition = Camera.main.ScreenToWorldPoint (playerPosition);

	//	Debug.Log ("Player Pos after conversion: " + playerPosition.x);

		player.transform.position = playerPosition;

	
	}

	IEnumerator moveRight() {

		if ((playerPosition.x + (screenWidth / 4)) < screenWidth - 30) {
			playerPosition.x += (screenWidth / 4);
		}
		
		yield return null;
	
	}
	IEnumerator moveLeft() {
		if ((playerPosition.x - (screenWidth / 4)) > 0) {
			playerPosition.x -= (screenWidth / 4);
		}
		yield return null;
	}	

	//On Collider hit, destroy player and call death screen
	void OnCollisionEnter2D(Collision2D coll) 
	{

		//Destroy Player Object
		Destroy (player);
		//Set Speed back to 1 in Obstacle Prefab
		ObstaclePrefab.speed = 1;
		//Set Death Count
		PlayerPrefs.SetInt ("DeathCount", PlayerPrefs.GetInt ("DeathCount") + 1);
		//Store Score array in PlayerPrefs
		score.storeScore();
		//Store score in PlayerPrefs
		PlayerPrefs.SetInt("CurrentScore", (int)score.currentTime);
		//Reset Score
		score.resetScore();
		//Play Ad
		playAdOnDeath ();
		//Death Scene
		Application.LoadLevel(2);

	}

	private void playAdOnDeath() {

		scoreAmount = PlayerPrefs.GetInt ("CurrentScore");

		if (scoreAmount >= 30) {
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
			} else {
				Debug.Log ("NOT Showing Ad");
			}
			PlayerPrefs.SetInt ("TimesDied", 0);
		}
		else {
			if (PlayerPrefs.GetInt("TimesDied") == 0)
				PlayerPrefs.SetInt ("TimesDied", 1);
			else
				PlayerPrefs.SetInt ("TimesDied", PlayerPrefs.GetInt("TimesDied") + 1);
		}

		timesPlayed = PlayerPrefs.GetInt ("TimesDied");

		if (timesPlayed == 4) {
			if (Advertisement.IsReady () && !(Advertisement.isShowing)) {
				Advertisement.Show ();
				Debug.Log ("Showing Ad");
			} else {
				Debug.Log ("NOT Showing Ad");
			}
			PlayerPrefs.SetInt ("TimesDied", 0);
		}

	}



}
	