using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class GameController : MonoBehaviour {
    public int life;
    public int point = 0;
    public string message = "default message";
    public bool next = false;
    private int personType = 0;


    public GameObject[] faces;

    public GameObject earth;
    public GameObject buttons;

    public Transform gamesSpawner; 

    public GameObject[] games;
    public GameObject[] info;
    public GameObject[] caras;
    public GameObject[] lifeSprite;

    public GameObject[] mensaje; 

    public GameObject[] heat; 

    private void Start()
    {
        nextPerson();

    }
    
    void Update () {
        lifeControl();
        if (next)
        {
            nextPerson();
            next = false; 
        }
	}

    void nextPerson()
    {
        earth.GetComponent<RotateEarth>().doRotate = true;
        buttons.SetActive(true);
        randomPerson();
    }

    void randomPerson()
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                faces[0].SetActive(true);
                break;
            case 1:
                faces[1].SetActive(true);
                break;
            case 2:
                faces[2].SetActive(true);
                break;
            case 3:
                faces[3].SetActive(true);
                break;
        }
    }

    public void show()
    {
        buttons.SetActive(false);
        info[0].SetActive(true);
        GameObject clone = Instantiate(games[0], gamesSpawner.position, gamesSpawner.rotation);
        clone.transform.parent = gamesSpawner.transform;
        games[0].SetActive(true);
        disableFaces();
    }

    public void empathize()
    {
        buttons.SetActive(false);
        info[1].SetActive(true);
        GameObject clone = Instantiate(games[1], gamesSpawner.position, gamesSpawner.rotation);
        clone.transform.parent = gamesSpawner.transform;
        disableFaces();
    }

    public void listen()
    {
        buttons.SetActive(false);
        info[2].SetActive(true);
        GameObject clone = Instantiate(games[2], gamesSpawner.position, gamesSpawner.rotation);
        clone.transform.parent = gamesSpawner.transform;
        disableFaces();
    }

    public void reason()
    {
        buttons.SetActive(false);
        info[3].SetActive(true);
        GameObject clone = Instantiate(games[3], gamesSpawner.position, gamesSpawner.rotation);
        clone.transform.parent = gamesSpawner.transform;
        disableFaces();
    }

    void disableFaces()
    {
        for (int i = 0; i < caras.Length; i++)
        {
            caras[i].SetActive(false);
        }
    }

    void lifeControl()
    {
        switch (life)
        {
            case 0:
                lifeSprite[0].SetActive(false);
                lifeSprite[1].SetActive(false);
                lifeSprite[2].SetActive(false);
                SceneManager.LoadSceneAsync(1);
                break;
            case 1:
                lifeSprite[0].SetActive(true);
                lifeSprite[1].SetActive(false);
                lifeSprite[2].SetActive(false);
                break;
            case 2:
                lifeSprite[0].SetActive(true);
                lifeSprite[1].SetActive(true);
                lifeSprite[2].SetActive(false);
                break;
            default:
                lifeSprite[0].SetActive(true);
                lifeSprite[1].SetActive(true);
                lifeSprite[2].SetActive(true);
                break;
        }
    }

    public void heatCorret()
    {
        heat[0].SetActive(true);
        mensaje[0].SetActive(true);
    }

    public void heatFail()
    {
        heat[1].SetActive(true);
        mensaje[1].SetActive(true);
    }
}
