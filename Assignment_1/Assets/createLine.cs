using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createLine : MonoBehaviour
{

    GameObject line;
    private LineRenderer lineObject;

    private GameObject target1 = null;
    private GameObject target2 = null;

    //private LineRenderer lineObject;


    // Use this for initialization
    void Start()
    {
       line = new GameObject();
           
             line.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(object1);



        target1 = GameObject.FindGameObjectWithTag("Object1");
        target2 = GameObject.FindGameObjectWithTag("Object2");

           
            lineObject = line.GetComponent<LineRenderer>();

            lineObject.SetPosition(0, target1.transform.position);
            lineObject.SetPosition(1, target2.transform.position);

        
    }

}
