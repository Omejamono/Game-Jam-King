using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public string tago;
    public GameObject juego;
    private GameObject global;

    // Use this for initialization
    void Start () {
        global = GameObject.FindGameObjectWithTag("global");
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tago)
        {
            global.GetComponent<GameController>().life--;
            global.GetComponent<GameController>().heatFail();
            Destroy(juego);
        }

        if (collision.gameObject.tag =="end")
        {
            global.GetComponent<GameController>().point += 50;
            global.GetComponent<GameController>().heatCorret();
            Destroy(juego);
        }
    }
}
