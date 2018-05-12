using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    //public variables

    //private variables
    private bool first;
    private Vector3 acceleration;
    private Vector3 vel;
    private float timer;
    private bool go;

	// Use this for initialization
	void Start () {
        first = true;
        acceleration = new Vector3(0.05f, 0, 0);
        vel = new Vector3(0.05f, 0, 0);
        timer = 0;

    }
	
	// Update is called once per frame
	void Update () {
 
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                first = false;
                timer = 0;
            }

            if (!first)
            {
                vel += acceleration;
                first = true;
            }
            transform.position -= vel;
        
    }


}
