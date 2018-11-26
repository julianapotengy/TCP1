using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    public bool canPause;
    public GameObject pauseMenuUI;

	void Start ()
    {
        isPaused = false;
        Time.timeScale = 1;
        canPause = true;
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            if (isPaused)
            {
                Resume();
            }
            else Pause();
        }
	}

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
}
