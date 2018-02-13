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
		
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {
		nosePosVector = shuttleNose.transform.localPosition;
		earthPosVector = planet_earth.transform.position;
		shuttleVector = shuttle.transform.position;

		Matrix4x4 noseMatrix = T (nosePosVector.x, nosePosVector.y, nosePosVector.z);
		//Matrix4x4 EarthMatrix = T (earthPosVector.x, earthPosVector.y, earthPosVector.z);
		//Matrix4x4 shuttleMatrix = T (shuttleVector.x, shuttleVector.y, shuttleVector.z);

		//Matrix4x4 inversedEarthMatrix = EarthMatrix.inverse;

		//Matrix4x4 res = shuttleMatrix * noseMatrix;  

//		Debug.Log ("nose" + noseMatrix); 
//		Debug.Log ("shuttle" + noseMatrix); 
//		Debug.Log ("Earth" + noseMatrix); 
//	    
		Matrix4x4 earthMatrix = planet_earth.transform.worldToLocalMatrix; 
		Matrix4x4 shuttleMatrix = shuttle.transform.localToWorldMatrix; 

		Matrix4x4 multipled = earthMatrix * shuttleMatrix * noseMatrix;  


//		Debug.Log (worldMatrix);

		if( Input.GetKey(KeyCode.Q)){
			Debug.Log (multipled);
		}

		if( Input.GetKey(KeyCode.W)){
//			Debug.Log (noseMatrix);
//			Debug.Log (res);
		}
	}

	private Matrix4x4 T (float x, float y, float z)
	{
		Matrix4x4 m = new Matrix4x4();

		m.SetRow(0, new Vector4(1, 0, 0, x));
		m.SetRow(1, new Vector4(0, 1, 0, y));
		m.SetRow(2, new Vector4(0, 0, 1, z));
		m.SetRow(3, new Vector4(0, 0, 0, 1));

		return m;
	}
}
