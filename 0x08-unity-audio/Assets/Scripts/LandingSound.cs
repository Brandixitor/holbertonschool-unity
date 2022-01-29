using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class LandingSound : MonoBehaviour
{
    private AudioSource LandingRockClip;
    public GameObject Player;


    void Start()
    {
        LandingRockClip = Player.GetComponent<AudioSource>();
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "naturePack_008")
            LandingRockClip.Play();
    }
}
