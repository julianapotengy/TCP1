using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject creditsPanel;
    public GameObject alien;

	void Start ()
    {
        menuPanel.SetActive(true);
        creditsPanel.SetActive(false);
        alien.SetActive(false);
	}
	
	void Update ()
    {
		
	}

    public void ChangeToCredits()
    {
        menuPanel.SetActive(false);
        creditsPanel.SetActive(true);
        alien.SetActive(true);
    }

    public void ChangeToMenu()
    {
        menuPanel.SetActive(true);
        creditsPanel.SetActive(false);
        alien.SetActive(false);
    }
}
