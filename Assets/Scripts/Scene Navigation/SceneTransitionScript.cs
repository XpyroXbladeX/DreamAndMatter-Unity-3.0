using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		//Scene currentScene = SceneManager.GetActiveScene ();
		//string sceneName = currentScene.name;
	}
	
	// Update is called once per frame
	void Update () {
		if ( (Input.touchCount >= 1) && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("Kayla'sScene-LevelText")) ) {
			SceneManager.LoadScene ("Prototype Scene");
		}
	}
}
