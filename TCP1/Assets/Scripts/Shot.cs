using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject powerUp;
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
        if (col.gameObject.tag == "Enemy")
        {
            int rand = Random.Range(1, 10);
            if (rand >= 7)
            {
                Instantiate(powerUp, this.transform.position, Quaternion.identity);
            }

            gameManager.GetComponent<Points>().DestroyEnemyPoints();
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
