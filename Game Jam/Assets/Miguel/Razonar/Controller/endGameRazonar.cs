using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGameRazonar : MonoBehaviour {
    public float timer;
    private GameObject global;
    public GameObject game;

    private float timeelap;

    private void Start()
    {
        global = GameObject.FindGameObjectWithTag("global");
        timeelap = timer + Time.time;
    }

    private void Update()
    {
        if (timeelap < Time.time)
        {
            //+1 Puntuaaciones 
            //Next Person 
            global.GetComponent<GameController>().point += 50;
            Destroy(game);
        }
    }

}
