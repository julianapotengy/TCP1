using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public VideoPlayer video;
    private float timer;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= 12)
        {
            SceneManager.LoadScene(1);
        }

        if (Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
	}
}
