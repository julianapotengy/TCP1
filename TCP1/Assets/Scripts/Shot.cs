using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gameManager;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameManager.GetComponent<GameOver>().EndGame();
        }

        if (col.gameObject.tag == "Enemy1")
        {
            col.GetComponent<Enemy1>().life = 0;
            Debug.Log("destruiu inimigo");
        }

        if (col.gameObject.tag == "Enemy2")
        {
            col.GetComponent<Enemy2>().life = 0;
            Debug.Log("destruiu inimigo");
        }
    }

}
