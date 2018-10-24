using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gameManager;
    private float speed;

    void Start ()
    {
        speed = 10;
        gameManager = GameObject.FindWithTag("GameController");
    }
	
	void Update ()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy1")
        {
            col.GetComponent<Enemy1>().life = 0;
            gameManager.GetComponent<Points>().DestroyEnemyPoints();
            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Enemy2")
        {
            col.GetComponent<Enemy2>().life = 0;
            gameManager.GetComponent<Points>().DestroyEnemyPoints();
            Destroy(this.gameObject);
        }
    }
}
