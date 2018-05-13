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

    private GameObject global;

	// Use this for initialization
	void Start () {
        way = 5;
        timer = 0;
        global = GameObject.FindGameObjectWithTag("global");
	}
	
	// Update is called once per frame
	void Update () {
        kokoro.transform.position = waypoints[way].transform.position;
        timer += Time.deltaTime;
        if(timer > 30)
        {
            Destroy(mastergame);

            int points = 0;

            switch (way)
            {
                case 5:
                    points = 10;
                    break;
                case 6:
                    points = 20; 
                    break;
                case 7:
                    points = 30;
                    break;
                case 8:
                    points = 40;
                    break;
                case 9:
                    points = 50; 
                    break;
                default:
                    global.GetComponent<GameController>().life --;
                    break;
            }
            global.GetComponent<GameController>().point += points;
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
