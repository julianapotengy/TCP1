using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [Header("Referência do Player")]
    public GameObject player;

    public float speed;
    
    void Start ()
    {
        speed = 10;
        player = GameObject.Find("Player");
	}
	
	void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == player)
        {
            if(player.GetComponent<PlayerBehaviour>().life < 3)
            {
                player.GetComponent<PlayerBehaviour>().life += 1;
                Destroy(this.gameObject);
            }
        }
    }
}
