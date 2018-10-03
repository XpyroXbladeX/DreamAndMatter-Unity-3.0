using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 10f;
	public static int meter;
	public Text meterText;
	/*public GameObject character;
	private Rigidbody characterBody; //
	private float ScreenWidth; //*/

	// Use this for initialization
	void Start () {
		meter = 50;
		meterText.text = meter.ToString();
//initialization
		/*ScreenWidth = Screen.width; //
		characterBody = character.GetComponent<Rigidbody>(); //*/
	}

	// Update is called once per frame
	void Update () {

	//	transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);
		meterText.text = meter.ToString(); //move player part

		if (Input.GetKeyDown (KeyCode.Escape)) {
		SceneManager.LoadScene ("MainMenu");
		}

		/*int i = 0; //

		while (i < Input.touchCount){
			if (Input.GetTouch(i).position.x > ScreenWidth/2){
				//move right
				RunCharacter(1.0f);//
			}
			if (Input.GetTouch(i).position.x < ScreenWidth/2){
				//moveleft
				RunCharacter(-1.0f);//
			}
			++i;*/

		//}
	}

	/*	void FixedUpdate(){
			#if UNITY_EDITOR
			RunCharacter(Input.GetAxis("Horizontal"));
			#endif
		}

		private void RunCharacter(float horizontalInput){
//move player//
			characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0)); //

		}*/


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
