using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Parâmetros")]
    public float maxHeight;
    public float minHeight;
    public float maxPosX;
    public float minPosY;

    [Header("Inimigos para Spawn")]
    public float maxTimer;
    public float decreaseTimer;
    public float startTimer;

    private float randPosition;

    [Header("Objetos para Spawn")]
    public GameObject enemyGround1;
    public GameObject enemyGround2;
    public GameObject enemyFly;
    public GameObject rock;

    float timer;

    void Start()
    {
        timer = startTimer;
    }
	
	void Update ()
    {
        Spawn();

        if(startTimer <= maxTimer)
        {
            startTimer = maxTimer;
        }
	}

    private void Spawn()
    {
        float randPos = Random.Range(0, 9);

        if (randPos > 5)
        {
            randPosition = maxHeight;
        }
        else randPosition = minHeight;

        timer -= 1f * Time.deltaTime;
        if (timer <= 0)
        {
            int randEnemy = Random.Range(1, 100);
            if (randEnemy <= 30)
            {
                Instantiate(enemyGround1, new Vector3(transform.position.x, randPosition, transform.position.z), Quaternion.identity);
            }
            else if(randEnemy > 30 && randEnemy <= 75)
            {
                Instantiate(enemyGround2, new Vector3(transform.position.x, randPosition, transform.position.z), Quaternion.identity);
            }
            else if(randEnemy > 75)
            {
                Instantiate(enemyFly, new Vector3(transform.position.x, randPosition, transform.position.z), Quaternion.identity);
            }
            else if(randEnemy >= 90)
            {
                Instantiate(rock, new Vector3(transform.position.x, randPosition, transform.position.z), Quaternion.identity);
            }
            startTimer -= decreaseTimer;
            timer = startTimer;
        }
    }
}
