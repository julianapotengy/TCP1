using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    public Text highScore;
    public Text score;

	void Start ()
    {
        highScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HIGHSCORE");
        score.text = "SCORE: " + PlayerPrefs.GetInt("SCORE");
	}
	
	void Update ()
    {
		
	}
}
