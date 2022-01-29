using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SliderControl : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetBGMVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
