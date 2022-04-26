using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    // Activat timer on trigger exit 
    void OnTriggerExit(Collider Player)
    {
        Player.GetComponent<Timer>().enabled = true;
    }
}
