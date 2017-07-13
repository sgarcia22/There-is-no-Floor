using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class Score : MonoBehaviour {

	public Text score;

	public int[] topScores = new int[5];
	private int tempScoreIndex;


	public float currentTime = 0f;
	private string convertedScore;
	public int intCurrentTime;


	private int maxScore;


	void Start () {

		score.text = "0";
		intCurrentTime = 0;

	}
	

	void Update () {

		currentTime = Time.timeSinceLevelLoad;
		intCurrentTime = (int)currentTime;
		convertedScore = intCurrentTime.ToString();
		score.text = convertedScore;

	}

	public void resetScore() {
		currentTime = 0f;
	}

	//Stores the score in the PlayerPrefs if it is applicable
	public void storeScore() {

		intCurrentTime = (int)currentTime;

		for (int i = 1; i <= 5; ++i) {

			topScores[i - 1] = PlayerPrefs.GetInt ("Score" + i.ToString());

		}
		//Sort the scores by decreasing order
		Array.Sort(topScores);

		for (int i = 0; i < topScores.Length; ++i) {
			//No new score will be added to the top 5
			if (i == 0 && intCurrentTime <= topScores [i])
				break;
			else if (intCurrentTime > topScores [i]) {

				tempScoreIndex = i;
				//Find if the score if bigger than any of the other listed scores
				for (int j = i; j < topScores.Length; ++j) {
				
					if (intCurrentTime > topScores [j])
						tempScoreIndex = j;
					else
						break;
				
				}

				if (tempScoreIndex == 0) {
					topScores [0] = intCurrentTime;
					break;
				}

				for (int k = 1; k < topScores.Length; k++) {
					//Shifting down previous scores
					if (k != tempScoreIndex)
						topScores [k - 1] = topScores [k];
					else {
						//Set the current Place 
						topScores [k - 1] = topScores [k];
						topScores [k] = intCurrentTime;
						break;
					}

				}

				break;
			
			}
		}


		for (int i = 1; i <= 5; ++i) {
			//Input the array into PlayerPrefs
			PlayerPrefs.SetInt ("Score" + i.ToString(), topScores[i - 1]);

		}

	}
}
