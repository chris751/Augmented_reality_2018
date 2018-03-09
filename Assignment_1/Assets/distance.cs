using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour {
    public GameObject Cube2;
    public GameObject Cube1;
    private bool createLine;
    // Use this for initialization
    void Start () {
       createLine = this.GetComponent<createLine>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
       // createLine = this.GetComponent<createLine>().enabled = false;
        if (Vector3.Distance(Cube1.transform.position, Cube2.transform.position) <30 && Vector3.Distance(Cube1.transform.position, Cube2.transform.position)!=21.5)
        {
            createLine = Cube1.GetComponent<createLine>().enabled = true;
        }

        Debug.Log(Vector3.Distance(Cube1.transform.position, Cube2.transform.position));


    }
}
