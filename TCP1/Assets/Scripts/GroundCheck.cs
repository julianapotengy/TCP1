using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Player player;
    public GameObject gameManager;

    void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
            player.grounded = true;

        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col);
            Debug.Log("destruiu inimigo");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
            player.grounded = true;

        if (col.gameObject.tag == "Enemy2")
        {
            Destroy(col);
            Debug.Log("destruiu inimigo");
            gameManager.GetComponent<Points>().DestroyEnemyPoints();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
            player.grounded = false;
    }
}
