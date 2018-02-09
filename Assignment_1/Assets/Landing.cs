using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {

	public GameObject shuttle;
	public GameObject Landingstrip;

	private Material quadColor;

	// Use this for initialization
	void Start () {
		quadColor = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeColor() {
		quadColor.SetColor (_Color, Color.red);
		quadColor.SetColor (_Color, Color.green);


	}


}
