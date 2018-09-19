using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkgrdMovement : MonoBehaviour {
	public float speed = 0.05f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0f, speed, 0f);
	}
}
