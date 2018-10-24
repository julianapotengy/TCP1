using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int pointsRound;
    private float timeFloat;
    private int timeInt;
    public Text pointsTxt;

	void Start ()
    {
        pointsRound = 0;
        timeFloat = 0;
        PlayerPrefs.SetInt("SCORE", 0);
    }
	
	void Update ()
    {
        TimePoints();
        timeFloat += Time.deltaTime;
        
        pointsTxt.text = PlayerPrefs.GetInt("SCORE").ToString();
    }

    public void DestroyEnemyPoints()
    {
        pointsRound += 5;
        PlayerPrefs.SetInt("SCORE", pointsRound);
    }

    void TimePoints()
    {
        if(timeFloat >= 1)
        {
            timeFloat = 0;
            pointsRound += 1;
            PlayerPrefs.SetInt("SCORE", pointsRound);
        }
    }

    public void RescuePoints()
    {
        pointsRound += 10;
        PlayerPrefs.SetInt("SCORE", pointsRound);
    }
}
