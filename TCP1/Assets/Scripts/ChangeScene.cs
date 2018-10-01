using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToGameOver()
    {
        SceneManager.LoadScene(2);
    }
}
