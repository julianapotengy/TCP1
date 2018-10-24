using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    private float speed, yValue;
    private Rigidbody2D rbody;
    public Transform[] positionsToMove;
    private bool moveUp;
    private GameObject gameManager, player;
    public int life;

    void Start ()
    {
        speed = 2f;
        rbody = GetComponent<Rigidbody2D>();
        moveUp = true;
        life = 1;
        gameManager = GameObject.FindWithTag("GameController");
        player = GameObject.FindWithTag("Player");
    }
	
	void Update ()
    {
        if (this.transform.position.y <= 2 && moveUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if(this.transform.position.y >= -2 && !moveUp)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (this.transform.position.y >= 2)
            moveUp = false;
        else if (this.transform.position.y <= -2)
            moveUp = true;

        if (life == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            player.GetComponent<Player>().playerLife -= 1;
            player.GetComponent<Player>().damageAnim = true;
            //gameManager.GetComponent<GameOver>().EndGame();
        }
    }
}
