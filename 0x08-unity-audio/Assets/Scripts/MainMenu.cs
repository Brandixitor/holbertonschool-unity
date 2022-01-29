using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    // Load scenes when pressing buttons
    public void LevelSelect(int level)
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Level01")
            SceneManager.LoadScene("Level01");
        else if (name == "Level02")
            SceneManager.LoadScene("Level02");
        else if (name == "Level03")
            SceneManager.LoadScene("Level03");
    }

    //
    public void Options()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "OptionsButton")
            SceneManager.LoadScene("Options");
        else if (name == "ExitButton")
        {
            Application.Quit();
            Debug.Log("Exited");
        }
    }
}
