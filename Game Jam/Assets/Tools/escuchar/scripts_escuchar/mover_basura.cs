using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_basura : MonoBehaviour
{
    //public variables
    

    //private variables
    private Vector3 direction;
    private float speed;

    private void Start()
    {
        direction = new Vector3(1.0f, 0.0f, 0.0f); 
        GetComponent<Rigidbody>().velocity = direction * speed;
    }

    private void Update()
    {
        speed = Input.GetAxis("Horizontal") * 8;
        GetComponent<Rigidbody>().velocity = direction * speed;
    }

}
