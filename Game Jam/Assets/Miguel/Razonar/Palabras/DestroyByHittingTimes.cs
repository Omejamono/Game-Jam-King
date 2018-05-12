using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByHittingTimes : MonoBehaviour {
    public string tag;
    public Vector3 inverseVelocity;
    public bool hitted = false;
    public float timeRA;
    public GameObject death;
    private GameObject goodWords;

    public float life; 

    private float stopRA;


    private void Start()
    {
        goodWords = GameObject.FindGameObjectWithTag("GoodWords");
    }

    private void Update()
    {
        if (hitted)
        {
            if (stopRA < Time.time) { 
                GetComponent<Rigidbody>().velocity += -inverseVelocity;
                hitted = false; 
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            life--;

            if (!hitted)
            {
                hitted = true;
                stopRA = Time.time + timeRA;
                GetComponent<Rigidbody>().velocity += inverseVelocity;
            }

            if (life <= 0)
            {
                Destroy(gameObject);

                GameObject clone = Instantiate(death, transform.position, transform.rotation);
                clone.transform.parent = goodWords.transform;
            }
        }
    }
}
