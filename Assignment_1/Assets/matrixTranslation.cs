using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matrixTranslation : MonoBehaviour {
	
	public  GameObject shuttleNose; 
	public  GameObject shuttle; 
	public  GameObject planet_earth; 

	private Vector3 nosePosVector;
	private Vector3 shuttleVector;
	private Vector3 earthPosVector;

	private Matrix4x4 noseMatrix;

	private Matrix4x4 multiplied;

	private string collisionDisplay = "test "; 
		
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {
		
		
		nosePosVector = shuttleNose.transform.localPosition;
		earthPosVector = planet_earth.transform.position;
		shuttleVector = shuttle.transform.position;

		noseMatrix = Matrix4x4.TRS (transform.localPosition, transform.localRotation, transform.localScale);  
		Matrix4x4 earthMatrix = planet_earth.transform.worldToLocalMatrix; 
		Matrix4x4 shuttleMatrix = shuttle.transform.localToWorldMatrix; 

		multiplied = earthMatrix * shuttleMatrix * noseMatrix;  
		checkForEathCollision ();
	}

	private void checkForEathCollision(){
		Vector4 nosePos = multiplied.GetColumn (3);
		Vector2 posVector = new Vector2 (nosePos.x, nosePos.z);
			
		bool heightCollision = (planet_earth.transform.localScale.x / 2) > nosePos.y * 20;
		bool widthCollision = posVector.magnitude * 20 < (planet_earth.transform.localScale.x / 2);

		if (widthCollision && heightCollision) {
			if (nosePos.z > 0) {
				collisionDisplay = "Northern hemisphere";
			} else if (nosePos.z < 0) {
				collisionDisplay = "Southern hemisphere";
			} 
		} else {
			collisionDisplay = "No collision";
		}
	}

	private void OnGUI(){
		GUI.color = Color.blue;
		GUI.Label (new Rect (10, 40, 500, 100), " " +collisionDisplay);
	}
}
