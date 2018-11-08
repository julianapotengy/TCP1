using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public enum IAMode { EnemyGround, EnemyFly, Rock, Prisioner }

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
            case IAMode.Prisioner:
                Prisioner();
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
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (this.transform.position.y >= -2.5 && !moveUp)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (this.transform.position.y >= 2)
            moveUp = false;
        else if (this.transform.position.y <= -2.5)
            moveUp = true;
    }

    void Rock()
    {

    }

    void Prisioner()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            gameManager.GetComponent<SoundManager>().PlayDamage();
        }
        if(this.gameObject.name.Equals("Prisioner(Clone)") && col.tag.Equals("Player"))
        {
            gameManager.GetComponent<Points>().RescuePoints();
        }
    }
}
