using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGameRazonar : MonoBehaviour {
    public float timer;
    public GameObject globalController;
    public GameObject game;

    private float timeelap;

    private void Start()
    {
        timeelap = timer + Time.time;
    }

    private void Update()
    {
        if (timeelap < Time.time)
        {
            //+1 Puntuaaciones 
            //Next Person 
            Destroy(game);
        }
    }

}
