using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simonWaiting : MonoBehaviour {
    private float timer;

    private bool started = false; 

    public float counter;

    public GameObject Heart;

    private void Start()
    {
    }

    void Update () {
        if (!started)
        {
            Heart.SetActive(false);
            started = true;
            timer = Time.time + counter;
        }
        else{
            if (timer < Time.time)
            {
                started = false;
                GetComponent<empatizarController>().levelup = true;
                this.enabled = false;
            }
        }
	}
}
