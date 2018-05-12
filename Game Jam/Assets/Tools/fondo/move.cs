using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    //public variables
    public float speed;
    public Vector3 direction;
    //private variables

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += direction * speed;
        if(transform.position.x >= 1850)
        {
            transform.position = new Vector3(-1620, transform.position.y, transform.position.z);
        }
    }
}
