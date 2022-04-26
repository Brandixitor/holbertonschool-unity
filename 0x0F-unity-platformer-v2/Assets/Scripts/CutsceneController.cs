using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneController : MonoBehaviour
{

    public GameObject Player;
    public GameObject Camera;
    public GameObject Timer;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(5.0f);
        Camera.SetActive(true);
        Timer.SetActive(true);
        gameObject.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = true;
    }
}
