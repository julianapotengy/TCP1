using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GameObject player;
    public GameObject gameOverPanel;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if(player.GetComponent<PlayerBehaviour>().life <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        if(PlayerPrefs.GetInt("HIGHSCORE") <= PlayerPrefs.GetInt("SCORE"))
        {
            PlayerPrefs.SetInt("HIGHSCORE", PlayerPrefs.GetInt("SCORE"));
        }
        gameOverPanel.SetActive(true);
    }
}
