using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPoint1;
    private float timeBtwSpawn1;
    public float startTimeBtwSpawn1, decreaseTime1, minTime1;

    public GameObject spawnPoint2;
    private float timeBtwSpawn2;
    public float startTimeBtwSpawn2, decreaseTime2, minTime2;

    void Start ()
    {
        minTime1 = 5;
        minTime2 = 3;
        timeBtwSpawn1 = startTimeBtwSpawn1;
        timeBtwSpawn2 = startTimeBtwSpawn2;
	}
	
	void Update ()
    {
        SpawnEnemy1();
        SpawnEnemy2();
	}

    void SpawnEnemy1()
    {
        if (timeBtwSpawn1 <= 0)
        {
            Instantiate(spawnPoint1, transform.position, Quaternion.identity);
            timeBtwSpawn1 = startTimeBtwSpawn1;
            if (startTimeBtwSpawn1 >= minTime1)
            {
                startTimeBtwSpawn1 -= decreaseTime1;
            }
        }
        else
        {
            timeBtwSpawn1 -= Time.deltaTime;
        }
    }

    void SpawnEnemy2()
    {
        if (timeBtwSpawn2 <= 0)
        {
            Instantiate(spawnPoint2, spawnPoint2.transform.position, Quaternion.identity);
            timeBtwSpawn2 = startTimeBtwSpawn1;
            if (startTimeBtwSpawn2 >= minTime2)
            {
                startTimeBtwSpawn2 -= decreaseTime2;
            }
        }
        else
        {
            timeBtwSpawn2 -= Time.deltaTime;
        }
    }
}
