using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	public void playGame() {
		SceneManager.LoadScene("Kayla'sScene-LevelText");
		//SceneManager.LoadScene("Prototype Scene");
	}
}
