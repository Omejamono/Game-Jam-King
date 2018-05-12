using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovement : MonoBehaviour {
    public float speed;
    public Vector3 direction; 

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
        GetComponent<simpleMovement>().enabled = false; 
    }

}
