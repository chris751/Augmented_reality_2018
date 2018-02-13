using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIgeneration : MonoBehaviour {
	public GameObject earth; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnGUI(){
		GUI.color = Color.red;
		GUI.Label (new Rect (10, 10, 500, 100), "Shuttle translation:   " + transform.position.x + "    " + transform.position.y + "    " + transform.position.z);
		GUI.Label (new Rect (10, 20, 500, 100), "Earth translation:   " + earth.transform.position.x + "    " + earth.transform.position.y + "    " + earth.transform.position.z);
	}




}
