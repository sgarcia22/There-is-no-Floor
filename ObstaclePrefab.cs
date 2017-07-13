using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ObstaclePrefab : MonoBehaviour {

	static public float speed = 1f;

	private Text score;
	private int scoreAmount;
	private int exponentForSpawnCalculation = 1;


	void Start () {

		score = GameObject.FindGameObjectWithTag ("Score").GetComponent<Text>();

		scoreAmount = Convert.ToInt32(score.text);

//		Debug.Log (scoreAmount);

		if (scoreAmount >= (Mathf.Pow (2, exponentForSpawnCalculation))) {
			Debug.Log ("Speed: " + speed);
			speed += 0.01f;
			exponentForSpawnCalculation++;
		}

	}

	void Update () {

		transform.Translate (new Vector3 (0f, 10f, 0f) * Time.deltaTime * speed);

		if (transform.position.y >= 10f) {
			Destroy (gameObject);
		}

	}  


		
}
