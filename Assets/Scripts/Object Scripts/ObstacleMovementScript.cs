using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementScript : MonoBehaviour {

	public float speed;
	public GameObject player;
	private Vector3 currentPosition;
	// Use this for initialization
	void Start () {
		currentPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition.y += speed * Time.deltaTime;
		transform.position = currentPosition;

		if(transform.position.y > player.transform.position.y + 5) {
			//Debug.Log ("Goodbye Cruel World!");
			Destroy (gameObject);
		}
	}
}
