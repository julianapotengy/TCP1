using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeSceneToCutscene()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeSceneToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToGameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
