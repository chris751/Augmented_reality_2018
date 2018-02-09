using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRender : MonoBehaviour {
    private Material material;
    public GameObject Cannon;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnRenderObject()
    {
      
            if (material == null)
                material = new Material(Shader.Find("Hidden/Internal-Colored"));
            material.SetPass(0);

            GL.Begin(GL.LINES);
            GL.Color(Color.red);
            GL.Vertex(Cannon.transform.position);
            GL.Vertex(Cannon.transform.position + (Cannon.transform.TransformDirection(Vector3.forward) * 20));
            GL.End();

            Debug.Log("hejeeh");

        
    }
}
