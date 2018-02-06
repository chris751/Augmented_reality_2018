using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metoer : MonoBehaviour {

	public GameObject earthPrefab;
	private Vector3 distance;
	private float xScale;
	private float zScale;

	void Update(){
		CalcDistance ();

		if (Input.GetKey (KeyCode.Space)){
			Debug.Log ("Distance " + distance.magnitude + " xScale : " + xScale + " zScale : " + zScale);
		}

	}

	void CalcDistance(){
		xScale = (earthPrefab.transform.lossyScale.x + transform.lossyScale.x)/2;
		zScale = (earthPrefab.transform.lossyScale.z + transform.lossyScale.z)/2;
		distance = transform.position - earthPrefab.transform.position;
		//Debug.Log ("Distance " + distance + " xScale : " + xScale + " yScale : " + yScale);
		if (Mathf.Abs(distance.magnitude) < xScale) {
			//Debug.Log ("Distance " + distance + " xScale : " + xScale + " zScale : " + zScale);
			Debug.Log ("Collision");
			//M
			GetComponent<ParticleSystem>().Play();
		}
			

	}
}
