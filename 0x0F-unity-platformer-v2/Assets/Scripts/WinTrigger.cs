using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class WinTrigger : MonoBehaviour
{
    public Text TimerText;

    public GameObject WinCanvas;

    public AudioSource VictorySound, BackgroundSound;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider Player)
    {
        Player.GetComponent<Timer>().enabled = false;
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
        WinCanvas.SetActive(true);
        BackgroundSound.Pause();
        VictorySound.Play();
    }
}
