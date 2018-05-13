using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parar : MonoBehaviour {
    //public variables
    public GameObject stop;
    public GameObject stop2;


    //private variables

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.tag == "walls") && (gameObject.name == "inferior"))
        {
            stop.GetComponent<control>().can_inf = false;
            stop2.GetComponent<control>().can_inf = false;
        }

        if ((collision.gameObject.tag == "walls") && (gameObject.name == "superior"))
        {
            stop.GetComponent<control>().can_sup = false;
            stop2.GetComponent<control>().can_sup = false;
        }
    }
}
