using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Footsteps : MonoBehaviour
{
    public CharacterController cc;
    public AudioSource RockClip;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && RockClip.isPlaying == false)
            RockClip.Play();
    }


    
}
