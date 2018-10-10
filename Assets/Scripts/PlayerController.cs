using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 10f;

	//Meter & UI
	public static int meter;
	public static float meterDeteriorationSpeed;
	public Text meterUI;
	//Time & UI
	public float timeLeft;
	public Text timeText;
	//End UI
	public Text endStatus;
	//Sounds
	public AudioSource goodPickupSoundSource;
	public AudioClip goodPickupSound;
	public AudioSource badPickupSoundSource;
	public AudioClip badPickupSound;

	// Use this for initialization
	void Start () {
		//Sounds
		goodPickupSoundSource.clip = goodPickupSound;
		badPickupSoundSource.clip = badPickupSound;

		meter = 80;
		//timeLeft = 120;
		meterDeteriorationSpeed = 3;
		timeText.text = timeLeft.ToString("F2");
		endStatus.text = "";
		meterUI.text = meter.ToString ();
	}

	// Update is called once per frame
	void Update () {
		//left/Right Arrow Movement
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);
		//meterText.text = meter.ToString();

		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");
		}

		//Updates Time Left for level
		timeLeft -= Time.deltaTime;
		timeText.text = timeLeft.ToString ("F2");

		//End State when Level is Over
		if (timeLeft <= 0) {
			if (meter >= 70) {
				endStatus.text = "You win!";
			} else if (meter < 70 && meter >= 30) {
				endStatus.text = "You didn't lose, but you didn't win either.";
			} else if (meter < 30) {
				endStatus.text = "You lost :(";
			}
			//fine for now, try to instead have boolean? Might mess with level transitions
			Time.timeScale = 0f;
		}

		//Updates Timer until next meter Decrease
		if (meterDeteriorationSpeed <= 0) {
			meter--;
			if (meter <= 0) {
				meter = 0;
			}
			meterDeteriorationSpeed = 3;
		} else {
			meterDeteriorationSpeed -= Time.deltaTime;
		}

		meterUI.text = meter.ToString();
	}


	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Pickup") {
			goodPickupSoundSource.PlayOneShot(goodPickupSound);
			meter += 10;
			if (meter >= 100)
				meter = 100;
			//Debug.Log ("Meter is currently at "+meter);
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "Obstacle") {
			badPickupSoundSource.PlayOneShot (badPickupSound);
			meter -= 10;
			if (meter <= 0)
				meter = 0;
			//Debug.Log ("Meter is currently at "+meter);
			Destroy (other.gameObject);
		}
			
	}
}
