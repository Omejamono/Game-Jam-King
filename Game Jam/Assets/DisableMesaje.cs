using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMesaje : MonoBehaviour {
    public float lifetime;
    public GameObject[] info;

    private float timer;
    private bool created = true;

    private GameObject global;

    private void Start()
    {
        global = GameObject.FindGameObjectWithTag("global");
    }

    private void Update()
    {
        if (created)
        {
            timer = Time.time + lifetime;
            created = false;
        }
        else
        {
            if (timer < Time.time)
            {
                created = true;
                for (int i = 0; i<info.Length; i++)
                {
                    info[i].SetActive(false);
                }
                global.GetComponent<GameController>().next = true;
                gameObject.SetActive(false);
            }
        }
    }
}
