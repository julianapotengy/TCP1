using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPoint;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn, decreaseTime, minTime;

	void Start ()
    {
        minTime = 0.8f;
        timeBtwSpawn = startTimeBtwSpawn;
	}
	
	void Update ()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(spawnPoint, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn >= minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
	}
}
