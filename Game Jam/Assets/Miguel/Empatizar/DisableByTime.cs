using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableByTime : MonoBehaviour {
    public float lifetime;

    private float timer;
    private bool created = true; 

    private void Update()
    {
        if (created)
        {
            timer = Time.time + lifetime;
            created = false; 
        }
        else { 
            if (timer < Time.time)
            {
                created = true; 
                gameObject.SetActive(false);
            }
        }
    }
}
