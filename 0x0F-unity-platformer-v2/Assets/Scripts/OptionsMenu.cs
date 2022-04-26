using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OptionsMenu : MonoBehaviour
{
    public GameObject KeyBindingMenu;
    public GameObject OptionMenu;

    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene(MainMenu.previousSceneName);
    }

    public void Apply()
    {
        SceneManager.LoadSceneAsync(PlayerPrefs.GetString("Prev", "MainMenu"), LoadSceneMode.Single);
    }

    public void Keys()
    {
        OptionMenu.SetActive(false);
        KeyBindingMenu.SetActive(true);
    }
}
