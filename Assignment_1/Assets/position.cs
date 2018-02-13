using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {
    Vector3 ogPosition;
    public GameObject falcon;
	// Use this for initialization
	void Start () {
        ogPosition = transform.localPosition;
        ogPosition = new Vector3(5f,0.9f,4.6f);
    }
	
	// Update is called once per frame
	void Update () {
        Quaternion rotation = falcon.transform.rotation;
        transform.rotation = rotation;
        transform.position = ogPosition + falcon.transform.position;
	}
}
