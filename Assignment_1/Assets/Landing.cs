using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {

	public GameObject shuttle;
	public GameObject landingstrip;

	private Material quadColor;

	private Vector3 shuttlePosition;
	private Vector3 landingstripPosition;


	// Use this for initialization
	void Start () {
		quadColor = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		shuttlePosition = shuttle.transform.eulerAngles.normalized;
		landingstripPosition = landingstrip.transform.eulerAngles.normalized;

		Debug.Log (Vector3.Dot (shuttlePosition, landingstripPosition));

		if (Vector3.Dot (shuttlePosition, landingstripPosition) >= 0.9996f) {
			quadColor.color = Color.green;
		} else {
			quadColor.color = Color.red;
		}
	}
}
