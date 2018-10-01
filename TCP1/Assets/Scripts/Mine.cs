using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    private GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameController");
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            gameManager.GetComponent<GameOver>().EndGame();
        }
    }
}
