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

		//shuttlePosition = shuttle.transform.rotation;
		//landingstripPosition = landingstrip.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Vector3.Dot (shuttlePosition, landingstripPosition));
		if (Vector3.Dot (shuttlePosition, landingstripPosition) <= 1.2f && Vector3.Dot (shuttlePosition, landingstripPosition) >= 0.8) {
			//quadColor.SetColor (_Color, Color.green);
			quadColor.color = Color.green;
		} else {
			//quadColor.SetColor (_Color, Color.red);
			quadColor.color = Color.red;
		}
	}
}
