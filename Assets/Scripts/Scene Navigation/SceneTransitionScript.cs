using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {
	//public Button m_descendButton;

	// Use this for initialization
	void Start () {
		//Scene currentScene = SceneManager.GetActiveScene ();
		//string sceneName = currentScene.name;
		Debug.Log ("Load next level");
		//Button transButton = m_descendButton.GetComponent<Button> ();
		//m_descendButton.onClick.AddListener (TaskOnClick);
		SceneManager.LoadSceneAsync ("PrototypeScene");
	}


	// Update is called once per frame
	//void Update () {
		/*if ( (Input.touchCount >= 1) && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("Kayla'sSceneLevelText")) ) {
			SceneManager.LoadSceneAsync ("Prototype Scene"); */


		}

