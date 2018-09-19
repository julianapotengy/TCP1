using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject obstacle;

    private void Update()
    {
        if (this.gameObject.name == "SpawnPoints(Clone)")
        {
            int rand = Random.Range(0, spawnPoints.Length);
            Instantiate(obstacle, spawnPoints[rand].transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
