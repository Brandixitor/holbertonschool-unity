using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "BackButton")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
