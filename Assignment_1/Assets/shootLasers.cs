using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootLasers : MonoBehaviour {
    public GameObject Cannon1;
    public GameObject Cannon2;
    private bool shootCannon1;
    private bool shootCannon2;


    // Use this for initialization
    void Start () {
       shootCannon1= Cannon1.GetComponent<Lasers>().enabled=false;
       shootCannon2=  Cannon2.GetComponent<Lasers>().enabled = false;
    }

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("space"))
        {
        Cannon1.GetComponent<Lasers>().enabled = true;
        Cannon2.GetComponent<Lasers>().enabled = true;
        }else
        {
            Cannon1.GetComponent<Lasers>().enabled = false;
            Cannon2.GetComponent<Lasers>().enabled = false;
        }
      
    }

}

