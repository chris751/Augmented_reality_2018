using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metoer : MonoBehaviour {

	public GameObject earthPrefab;
	private Vector3 distance;
	private float xScale;

	private float imageScaleX;
	private float sunScaleX;
	private float earthScaleX;
	private float meteorScaleX;
	private float image2ScaleX;

	private float realXScale;

	void Start(){
		imageScaleX = earthPrefab.transform.parent.parent.localScale.x;
		sunScaleX = earthPrefab.transform.parent.localScale.x;
		earthScaleX = earthPrefab.transform.localScale.x;
		meteorScaleX = transform.localScale.x;
		image2ScaleX = transform.parent.localScale.x;

		realXScale = ((imageScaleX * sunScaleX * earthScaleX) + (image2ScaleX * meteorScaleX))/2;

	}

	void Update(){
		CalcDistance ();

		if (Input.GetKey (KeyCode.Space)){
			Debug.Log ("real scale : " + realXScale);
			Debug.Log ("lossy Scale : " + xScale);
		}

	}

	void CalcDistance(){
		xScale = (earthPrefab.transform.lossyScale.x + transform.lossyScale.x)/2;
		distance = transform.position - earthPrefab.transform.position;
		if (Mathf.Abs(distance.magnitude) < realXScale) {
			Debug.Log ("Collision");
			GetComponent<ParticleSystem>().Play();
		}


	}
}
