using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed = 1;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
