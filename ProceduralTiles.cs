using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
public class ProceduralTiles : MonoBehaviour {


	public GameObject obstaclePrefab;

	private GameObject obstacle;
	private Vector3[] positions;
	private Vector3 tempPosition;
	private Vector3 tempMovement;

	private float screenWidth;
	private float screenHeight;
	private float moveBy;
	private int randomIndex;
	private int random;
	private int[] randomArray;
	//Will record previous four tiles 
	private int[] previousTiles = new int[4];
	private int temp;
	private bool instantiated = false;

	private float secondsToSpawn = 0.5f;

	private float xAxis;
	private Vector3 movePosition;
	private Vector3 newPosition;

	void Start () {

		positions = new Vector3[3];

		screenWidth = Camera.main.pixelWidth;
		screenHeight = Camera.main.pixelHeight;
		moveBy = screenWidth / 4;

		tempPosition = obstaclePrefab.transform.position;

		//Make sure it stays on top of the background
		tempPosition.z = 0;
		tempPosition.y = -60;
		tempPosition.x = screenWidth / 2;

		//Middle Tile
		positions [0] = tempPosition;
		//Left Tile
		tempPosition.x -= moveBy;
		positions [1] = tempPosition;
		//Right Tile
		tempPosition.x += (moveBy * 2);
		positions [2] = tempPosition;

		//For each element in the array, must convert back to world point
		for (int i = 0; i < positions.Length; ++i) {
			positions[i] = Camera.main.ScreenToWorldPoint (positions[i]);
		}

		//InvokeRepeating("spawnTile", 1.0f, secondsToSpawn);
		Invoke("spawnTile", secondsToSpawn);
	}

	// Change the transform value & spawn continuously 
	void Update () {
		
		//Increasing the randomness factor
		int random1 = Random.Range (0, 3);
		int random2 = Random.Range (0, 3);
		int random3 = Random.Range (0, 3);
		int random4 = Random.Range (0, 3);

		randomArray = new int[] {random1, random2, random3, random4};

		randomIndex = Random.Range (0, randomArray.Length);

		random = randomArray [randomIndex];



		if (instantiated) {
			Debug.Log ("RANDOM NUMBER" + random);

			obstaclePrefab.transform.position = positions [random];

			xAxis = obstaclePrefab.transform.position.x;

			obstacle = Instantiate (obstaclePrefab, new Vector3(xAxis, -10f, 0f), Quaternion.identity) as GameObject;
			//Puts all of the objects created under the parent object
			obstacle.transform.parent = transform;

			if (obstacle.transform.position.y >= 10f) {
				GameObject.Destroy(obstacle);
			}
		}

		instantiated = false;


	}

	private void spawnTile() {
		
		instantiated = true;
		Invoke("spawnTile", secondsToSpawn);

	}

		
}


