using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    private int score;
    private GameObject glogal;

    // Use this for initialization
    void Start () {
        score = 0;
        setScore ();
        glogal = GameObject.FindGameObjectWithTag("global");

    }
	
	// Update is called once per frame
	void Update () {
       score =  glogal.GetComponent<GameController>().point;
        //counting code
        setScore ();
    }

    void setScore () {
        scoreText.text = "Score: " + score.ToString();
    }
}
