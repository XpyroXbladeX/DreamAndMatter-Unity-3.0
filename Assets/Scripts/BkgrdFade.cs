using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkgrdFade : MonoBehaviour {
	SpriteRenderer sprRender;


	// Use this for initialization
	void Start () {
		sprRender = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerController.meter < 33) {
		sprRender.color -= new Color(0, 0, 0, Time.deltaTime);
		}
	}
}
