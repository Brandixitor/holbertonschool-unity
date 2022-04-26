using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PCanvas;

    bool paused = false;

    public GameObject player;

    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();   
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void Update()
    {
        if (playerControls.Player.AltPause.ReadValue<float>() == 1)
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
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
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
