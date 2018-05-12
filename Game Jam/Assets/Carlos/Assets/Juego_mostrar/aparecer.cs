using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecer : MonoBehaviour {
    //public variables
    public GameObject limite_sup;
    public GameObject limite_inf;

    //private variables

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "middle")
        {
            limite_inf.SetActive(true);
            limite_sup.SetActive(true);
        }
    }
}
