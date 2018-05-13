using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class resetGame : MonoBehaviour {
    public float lifetime;
    public GameObject[] info;

    private float timer;

    private void Start()
    {
        timer = Time.time + lifetime;
    }

    // Update is called once per frame
    void Update () {
        if (timer < Time.time)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
