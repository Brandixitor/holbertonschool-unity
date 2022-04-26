using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public static string previousSceneName = "MainMenu";

    // Load scenes when pressing buttons
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }


    public void Options()
    {
        previousSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        //PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        //Debug.Log("Exited");
        Application.Quit();
    }
}
