using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("perdeu. highscore: " + PlayerPrefs.GetInt("HIGHSCORE"));
        if(PlayerPrefs.GetInt("HIGHSCORE") <= PlayerPrefs.GetInt("SCORE"))
        {
            PlayerPrefs.SetInt("HIGHSCORE", PlayerPrefs.GetInt("SCORE"));
        }
    }
}
