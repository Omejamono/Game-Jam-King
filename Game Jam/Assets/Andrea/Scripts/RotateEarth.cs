using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour {

    public Transform from;
    public Transform to;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

  
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,transform.rotation.y+30, transform.rotation.eulerAngles.z+90));
        }
	}
}
