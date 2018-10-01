using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("perdeu. highscore: " + PlayerPrefs.GetInt("HIGHSCORE"));
        if(PlayerPrefs.GetInt("HIGHSCORE") <= PlayerPrefs.GetInt("SCORE"))
        {
            PlayerPrefs.SetInt("HIGHSCORE", PlayerPrefs.GetInt("SCORE"));
        }
        SceneManager.LoadScene(2);
    }
}
