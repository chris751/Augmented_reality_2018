using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour {
    public GameObject Cannon;
    // Use this for initialization
    private Material material;
    private Ray ray;
	void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
       
          
            // Debug.Log("space key was pressed");

            // Physics.Raycast(Cannon.transform.position, Vector3.forward);
            // OnRenderObject();
            Vector3 test = Cannon.transform.TransformDirection(Vector3.forward);

            Vector3 forward = Cannon.transform.TransformDirection(Vector3.forward) * 20;


            Physics.Raycast(Cannon.transform.position, test, 20);
            Debug.DrawRay(Cannon.transform.position, forward, Color.green, 0.05f, true);


       

      
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

            // Debug.Log("hejeeh");

        
    }
}

 

