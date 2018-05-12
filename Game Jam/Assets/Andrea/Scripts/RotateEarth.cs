using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour {

    public float speed;

    public Vector3  currentRotation;
    public float correctRotation = 0.0f;

    public float next = 0;
    public float timer = 0;
    private int num = 5;

    public bool doRotate = false; 


    bool rotating = false;

    // Update is called once per frame
    void Update() {
        if (timer < Time.time && doRotate)
        {
            rotating = true;
            correctRotation += 90;
            doRotate = false;

            timer = Time.time + next;
        }

        if (rotating)
        {
            currentRotation = transform.eulerAngles;
            currentRotation.z = Mathf.Lerp(currentRotation.z, correctRotation, Time.deltaTime * speed);

            if (currentRotation.z > 355)
            {
                currentRotation.z = 0;
                correctRotation = 0;
            }

            transform.eulerAngles = currentRotation;
        }
  
    }
}
