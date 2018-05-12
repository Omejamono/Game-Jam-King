using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    private int score;

    // Use this for initialization
    void Start () {
        score = 0;
        setScore ();
	}
	
	// Update is called once per frame
	void Update () {

        //counting code
        setScore ();
    }

    void setScore () {
        scoreText.text = "Score: " + score.ToString();
    }
}
