using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour {

	private float timer;
	public GameObject Obstacle;
	public GameObject player;
	private float xPos;
	// Use this for initialization
	void Start () {
		timer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			//choose a random number for x position and spawn obstacle
			xPos = Random.Range(-3,3);
			//Debug.Log ("X position is " + xPos);
			Instantiate(Obstacle, new Vector3(xPos,-10,0), Quaternion.identity);
			//Debug.Log("Obstacle Spawned!!!");
			timer = 10;
		} else if (timer > 0) {
			timer -= Time.deltaTime;
		}
	}
}
