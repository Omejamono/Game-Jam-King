using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseRazonar : MonoBehaviour {
    public GameObject game;
    public string tag;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            Destroy(game);
        }
    }
}
