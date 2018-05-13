using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empatizarUser : MonoBehaviour {
    public int[] arrayFlechas;
    public GameObject[] flechas;
    public GameObject game; 
    private int aux;
    private GameObject global;

    private void Start()
    {
        global = GameObject.FindGameObjectWithTag("global");
    }

    void Update () {
        arrayFlechas = GetComponent<empatizarController>().arrayFlechas;

        if (aux == arrayFlechas.Length)
        {
            aux = 0;
            this.enabled = false;
            GetComponent<simonWaiting>().enabled = true;
        }
        
        //Abajo
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (arrayFlechas[aux] == 1) {
                flechas[arrayFlechas[aux]].SetActive(true);
                aux++;
            }else
            {
                Destroy(game);
                global.GetComponent<GameController>().life--;
                global.GetComponent<GameController>().heatFail();
            }
        }

        //Derecha
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (arrayFlechas[aux] == 2)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                aux++;
            }
            else
            {
                Destroy(game);
                global.GetComponent<GameController>().life--;
                global.GetComponent<GameController>().heatFail();
            }
        }
   
        //Izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (arrayFlechas[aux] == 3)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                aux++;
            }
            else
            {
                Destroy(game);
                global.GetComponent<GameController>().life--;
                global.GetComponent<GameController>().heatFail();
            }
        }
 
        //Arriba
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (arrayFlechas[aux] == 0)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                aux++;
            }
            else
            {
                Destroy(game);
                global.GetComponent<GameController>().life--;
                global.GetComponent<GameController>().heatFail();
            }
        }
	}
}
