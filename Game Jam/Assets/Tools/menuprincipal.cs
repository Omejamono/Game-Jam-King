using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipal : MonoBehaviour {
    public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void jugar()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void salir()
    {
        Application.Quit();
    }
}
