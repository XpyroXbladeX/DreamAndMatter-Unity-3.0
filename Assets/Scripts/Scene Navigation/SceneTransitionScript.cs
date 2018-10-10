using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {
	public Button m_descend;


	// Use this for initialization
	void Start () {
		Debug.Log ("Load next level");
		Button transButton = m_descend.GetComponent<Button> ();
		transButton.onClick.AddListener (TaskOnClick);

	}

	public void TaskOnClick () {
			SceneManager.LoadSceneAsync ("PrototypeScene");
	}

	// Update is called once per frame
	//void Update () {
		/*if ( (Input.touchCount >= 1) && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("Kayla'sSceneLevelText")) ) {
			SceneManager.LoadSceneAsync ("Prototype Scene"); */


		}

