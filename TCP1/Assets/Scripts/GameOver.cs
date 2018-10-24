using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if(player.GetComponent<Player>().playerLife <= 0)
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
        SceneManager.LoadScene(2);
    }
}
