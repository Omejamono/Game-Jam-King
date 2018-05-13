using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour {
    //public variables

    //private variables
    private GameObject padre;

	// Use this for initialization
	void Start () {
        padre = GameObject.FindGameObjectWithTag("padre");
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    public void OnTriggerExit(Collider other)
    { 
    }

}
