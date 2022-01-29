using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PCanvas;

    bool paused = false;

    public GameObject player;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Resume();
            else
                Pause();
        }
    }

    //
    public void Pause()
    {
        PCanvas.SetActive(true);
        player.GetComponent<Timer>().enabled = false;
        paused = true;
    }

    //
    public void Resume()
    {
        PCanvas.SetActive(false);
        player.GetComponent<Timer>().enabled = true;
        paused = false;
    }

    //
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    //
    public void Restart()
    {

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    //
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
