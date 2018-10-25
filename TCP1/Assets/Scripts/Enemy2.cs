using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private GameObject gameManager, player;
    public SoundManager soundMng;
    public int life;

    void Start ()
    {
        life = 1;
        gameManager = GameObject.FindWithTag("GameController");
        player = GameObject.FindWithTag("Player");
        soundMng = gameManager.GetComponent<SoundManager>();
    }
	
	void Update ()
    {
		if(life == 0)
        {
            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            soundMng.PlayDamage();
            player.GetComponent<Player>().playerLife -= 1;
            player.GetComponent<Player>().damageAnim = true;
            //gameManager.GetComponent<GameOver>().EndGame();
        }
    }
}
