using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFadeIn : MonoBehaviour {
	private TextMeshPro textMesh;
	public Color color;
	public float duration = 1.5f;
	float alpha;


	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMeshPro> ();
		textMesh.color = color;
		alpha = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//Color -= new Color (225,225,225, Time.deltaTime);
		alpha += Time.deltaTime / duration;
		textMesh.color = new Color (textMesh.color.r, textMesh.color.g, textMesh.color.b, alpha);
	}
}
