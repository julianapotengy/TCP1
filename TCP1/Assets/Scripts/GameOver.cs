using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GameObject player;
    public GameObject gameOverPanel;
    public PauseMenu pause;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void EndGame()
    {
        if(PlayerPrefs.GetInt("HIGHSCORE") <= PlayerPrefs.GetInt("SCORE"))
        {
            PlayerPrefs.SetInt("HIGHSCORE", PlayerPrefs.GetInt("SCORE"));
        }
        gameOverPanel.SetActive(true);
        pause.canPause = false;
        Time.timeScale = 0;
    }
}
