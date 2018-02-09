using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {

	public GameObject shuttle;
	public GameObject landingstrip;

	private Material quadColor;

	private Vector3 shuttlePosition;
	private Vector3 landingstripPosition;

	private Vector3 shuttleTranslation;


	// Use this for initialization
	void Start () {
		quadColor = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		shuttleTranslation = shuttle.transform.position;

		shuttlePosition = shuttle.transform.eulerAngles.normalized;
		landingstripPosition = landingstrip.transform.eulerAngles.normalized;

		Debug.Log (Vector3.Dot (shuttlePosition, landingstripPosition));

		if (Vector3.Dot (shuttlePosition, landingstripPosition) >= 0.9996f) {
			quadColor.color = Color.green;
		} else {
			quadColor.color = Color.red;
		}
	}

	private void OnGUI(){
		GUI.color = Color.red;
		GUI.Label (new Rect (10, 10, 500, 100), "translation:   " + shuttleTranslation.x + "    " + shuttleTranslation.y + "    " + shuttleTranslation.z);
	}

}
