using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empatizarController : MonoBehaviour {
    public int numCombi;
    public int[] arrayFlechas;
    public int numFlechas;
    public GameObject[] flechas;
    public GameObject game;
    public GameObject Heart;
    private GameObject global; 

    private int aux = 0;

    public bool simon = true;

    private float timer;
    public float nextFlecha;

    public bool levelup = false;

    private void Start()
    {
        fillArray();
        timer = nextFlecha + Time.time;
        global = GameObject.FindGameObjectWithTag("global");
    }

    private void Update()
    {
        if (simon)
        {
            doSimon();
        }
        else
        {
            if (levelup)
            {
                nextWave();
                levelup = false; 
            }
        }
    }

    private void fillArray()
    {
        arrayFlechas = new int[numFlechas];
        for (int i = 0; i < numFlechas; i++)
        {
            arrayFlechas[i] = Random.Range(0, 4);
        }
    }

    private void doSimon() {
        if (arrayFlechas.Length > aux) {
            if (timer < Time.time)
            {
                for (int i = 0; i < flechas.Length; i++) {
                    flechas[i].SetActive(false);
                } 
                flechas[arrayFlechas[aux]].SetActive(true);
                aux++;

                timer = nextFlecha + Time.time;
            }
        }
        else
        {
            simon = false;
            Heart.SetActive(true);
            GetComponent<empatizarUser>().enabled = true;
        }
    }

    private void nextWave()
    {
        numCombi--;
        if (numCombi == 0)
        {
            Destroy(game);
            global.GetComponent<GameController>().point++;
            global.GetComponent<GameController>().heatCorret();
        }
        aux = 0;
        numFlechas++;
        fillArray();
        simon = true; 
    }
}
