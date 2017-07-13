using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Did not implement
public class ChangeSprite : MonoBehaviour {

	public Image[] sprites;

	private Image currentSprite;
	private int arraySize;
	private int currentIndex;
	private int previousIndex;
	private bool hitMaxSize;


	void Start () {

		currentSprite = GetComponent<Image> (); 
		currentIndex = 0;
		arraySize = sprites.Length;
		InvokeRepeating ("changeSprite", 0.3f, 0.3f);
		hitMaxSize = false;

	}
	

	void Update () {


		}

	private void changeSprite() {

		currentSprite = sprites [currentIndex];

		Debug.Log (currentIndex);



	}


}
