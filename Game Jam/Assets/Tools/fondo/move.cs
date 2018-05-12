using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    //public variables
    public float speed;
    public Vector3 direction;

    public float xinit;
    public float xfinal;

    // Update is called once per frame
    void Update () {
        transform.position += direction * speed;
        if(transform.position.x >= xfinal)
        {
            transform.position = new Vector3(xinit, transform.position.y, transform.position.z);
        }
    }
}
