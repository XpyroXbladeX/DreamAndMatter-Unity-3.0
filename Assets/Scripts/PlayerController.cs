using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 10f;
	private int meter;

	// Use this for initialization
	void Start () {
		meter = 50;
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);

	}

	void onTriggerEnter(Collider other) {
		if (other.CompareTag ("Pickup")) {
			meter += 10;
			Debug.Log ("Meter is currently at "+meter);
			Destroy (other.gameObject);
		}
	}
}
