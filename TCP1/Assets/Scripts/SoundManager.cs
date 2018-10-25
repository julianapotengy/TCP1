using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip shotSnd, jumpSnd, damageSnd;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void PlayShot()
    {
        audioSrc.PlayOneShot(shotSnd);
    }

    public void PlayJump()
    {
        audioSrc.PlayOneShot(jumpSnd);
    }

    public void PlayDamage()
    {
        audioSrc.PlayOneShot(damageSnd);
    }
}
