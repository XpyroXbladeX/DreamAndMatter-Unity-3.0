using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Threading;

public class APpowerupKayla : MonoBehaviour {

	//Kayla's attempt at a power up - be nice!

	/* Script for "Astral Projection" Powerup
	 * Enables player to go beyond screen boundaries for certain amount of time
	 * so they can gather "bonus" points/pickups and special collectables that were 
	 * previously inaccessable. */

	//NOTE: LERP will need to be applied to camera so that it follows the player for this behavior!

	public GameObject APpowerup;
	public GameObject WallBarrier;
	public GameObject player;
	SpriteRenderer sprRender;
	public int timeLeft = 30;
	public Text countdown;
	public dreamMeter meter;
	public int dreamer;

	//References dreamMeter script
	void Awake (){
		meter = GetComponent<dreamMeter> ();
	}

	// Use this for initialization
	void Start () {
		sprRender = GetComponent<SpriteRenderer> ();
		sprRender.color -= new Color(0, 0, 0, Time.deltaTime);  //AP powerup starts transparent
		WallBarrier.SetActive(true);                           //wall barriers start as active
		StartCoroutine("LoseTime");                           //timer begins
		Time.timeScale = 1;
		Debug.Log ("Start came first!");

	}

	//Collision trigger
	void onTriggerEnter (Collider other) {
		if (other.CompareTag ("APpowerup")) {
			Destroy (other.gameObject);                   //destroy the AP powerup on collision
			Debug.Log ("Trigger came first!");
		}
	}

	IEnumerator LoseTime() {
		while (true){
			yield return new WaitForSeconds (1);
			timeLeft --;
		}
	}
		

	// Update is called once per frame
	void Update () {
		if (Time.deltaTime < 10 && dreamer > 1) {
			sprRender.color -= new Color (1, 1, 1, Time.deltaTime);  //AP powerup becomes opaque
		}

		if (CompareTag ("APpowerup")) {                       //if player collides with AP powerup
			WallBarrier.SetActive (false);                   //disable wall barriers
			//Destroy (CompareTag ("APpowerup"));           //destroy the AP powerup
			dreamer -- ;//3;                               //decrease meter count
			countdown.text = ("" + timeLeft);             //enable and show timer
			LoseTime ();

		}

		if (timeLeft > 0) {

			WallBarrier.SetActive (true);                                //reactivate wall barriers
			transform.Translate/*(gameObject.Player)*/(0, 4, 0);      //return player to starting point
		}

	}
}
