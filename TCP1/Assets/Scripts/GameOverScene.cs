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
        highScore.text = PlayerPrefs.GetInt("HIGHSCORE").ToString();
        score.text = PlayerPrefs.GetInt("SCORE").ToString();
	}
}
