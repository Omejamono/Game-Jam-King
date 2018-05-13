using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseRazonar : MonoBehaviour {
    public GameObject game;
    public string tag;
    private GameObject global;

    private void Start()
    {
        global = GameObject.FindGameObjectWithTag("global");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            global.GetComponent<GameController>().life--;
            global.GetComponent<GameController>().heatFail();
            Destroy(game);
        }
    }
}
