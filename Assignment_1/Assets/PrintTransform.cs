﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintTransform : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (gameObject.name + " rotation: " + transform.eulerAngles.normalized);

	}
}
