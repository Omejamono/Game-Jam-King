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


    bool rotating = false;
    float rotationTime; //
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotating = true;
            rotationTime = 0;

        }
        */
        for (int i = 0; i < num; i++) {
            if (timer < Time.time)
            {
                rotating = true;
                rotationTime = 0;
                correctRotation += 90;


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
            if (rotationTime > 1) {
                rotating = false;
            }
        }
    }
}
