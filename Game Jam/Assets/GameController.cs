using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int life;
    public int point = 0;
    public string message = "default message";
    public bool next = false; 

    public GameObject earth;
    public GameObject buttons;

    public GameObject[] games;
    public GameObject[] info;
    public GameObject[] caras; 

    private void Start()
    {
        nextPerson();
    }
    /*
    void Update () {
		if (next)
        {
            nextPerson();
            next = false; 
        }
	}
    */
    void nextPerson()
    {
        earth.GetComponent<RotateEarth>().doRotate = true;
        buttons.SetActive(true);
    }

    void randomPerson()
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                
                break;
            case 1:
                break;
            case 2: 
                break;
            case 3:
                break;
        }
    }

    public void show()
    {
        buttons.SetActive(false);
        info[0].SetActive(true);
        games[0].SetActive(true);
        disableFaces();
    }

    public void empathize()
    {
        buttons.SetActive(false);
        info[1].SetActive(true);
        games[1].SetActive(true);
        disableFaces();
    }

    public void listen()
    {
        buttons.SetActive(false);
        info[2].SetActive(true);
        games[2].SetActive(true);
        disableFaces();
    }

    public void reason()
    {
        buttons.SetActive(false);
        info[3].SetActive(true);
        games[3].SetActive(true);
        disableFaces();
    }

    void disableFaces()
    {
        for (int i = 0; i < caras.Length; i++)
        {
            caras[i].SetActive(false);
        }
    }
}
