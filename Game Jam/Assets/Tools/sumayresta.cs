using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumayresta : MonoBehaviour {
    //public variables
    public GameObject[] waypoints;
    public GameObject kokoro;
    public GameObject mastergame;

    //private variables
    private int way;
    private float timer;

	// Use this for initialization
	void Start () {
        way = 5;
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        kokoro.transform.position = waypoints[way].transform.position;
        timer += Time.deltaTime;
        if(timer > 30)
        {
            Destroy(mastergame);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Happy")
        {
            way++;
            if(way >= waypoints.Length)
            {
                way = 9;
            }
        }

        if (other.tag == "Sad")
        {
            way--;
            if (way <= 0)
            {
                way = 0;
            }
        }
    }
}
