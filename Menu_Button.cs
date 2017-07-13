using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour {

	public Button menu;

	public void goToMenu () {
		
		Application.LoadLevel (0);

	}

}
