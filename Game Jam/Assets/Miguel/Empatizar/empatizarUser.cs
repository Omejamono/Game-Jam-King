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
                global.GetComponent<GameController>().life--;
                aux++;
            }else
            {
                Destroy(game);
            }
        }

        //Derecha
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (arrayFlechas[aux] == 2)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                global.GetComponent<GameController>().life--;
                aux++;
            }
            else
            {
                Destroy(game);
            }
        }
   
        //Izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (arrayFlechas[aux] == 3)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                global.GetComponent<GameController>().life--;
                aux++;
            }
            else
            {
                Destroy(game);
            }
        }
 
        //Arriba
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (arrayFlechas[aux] == 0)
            {
                flechas[arrayFlechas[aux]].SetActive(true);
                global.GetComponent<GameController>().life--;
                aux++;
            }
            else
            {
                Destroy(game);
                global.GetComponent<GameController>().life--;
            }
        }
	}
}
