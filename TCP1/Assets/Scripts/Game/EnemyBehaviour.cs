using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public enum IAMode { EnemyGround, EnemyFly, Rock }

    [Header("Comportamento do Inimigo")]
    public IAMode thisEnemyMode;

    [Header("Atributos do Inimigo")]
    public float speed;

    [Header("Referência dos objetos")]
    public GameObject gameManager;
    public GameObject player;

    private bool moveUp;

    void Start ()
    {
        gameManager = GameObject.FindWithTag("GameController");
        player = GameObject.FindWithTag("Player");

        moveUp = true;
    }
	
	void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        switch (thisEnemyMode)
        {
            case IAMode.EnemyGround:
                EnemyGround();
                break;
            case IAMode.EnemyFly:
                EnemyFly();
                break;
            case IAMode.Rock:
                Rock();
                break;
        }
    }

    void EnemyGround()
    {

    }

    void EnemyFly()
    {
        if (this.transform.position.y <= 2 && moveUp)
        {
            transform.Translate(Vector2.up * 5 * Time.deltaTime);
        }
        else if (this.transform.position.y >= -2.5 && !moveUp)
        {
            transform.Translate(Vector2.down * 5 * Time.deltaTime);
        }

        if (this.transform.position.y >= 2)
            moveUp = false;
        else if (this.transform.position.y <= -2.5)
            moveUp = true;
    }

    void Rock()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            if(this.gameObject.name != "Rock(Clone)")
            {
                Destroy(this.gameObject);
                gameManager.GetComponent<SoundManager>().PlayDamage();
            }
            else if(this.gameObject.name == "Rock(Clone)")
            {
                gameManager.GetComponent<SoundManager>().PlayDamage();
            }
        }
    }
}
