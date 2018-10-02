using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 10f;
	public static int meter;
	public Text meterText;

	// Use this for initialization
	void Start () {
		meter = 50;
		meterText.text = meter.ToString();
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);
		meterText.text = meter.ToString();

		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");
		}

	}


	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Pickup") {
			meter += 10;
			//Debug.Log ("Meter is currently at "+meter);
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "Obstacle") {
			meter -= 10;
			//Debug.Log ("Meter is currently at "+meter);
			Destroy (other.gameObject);
		}
			
	}
}
