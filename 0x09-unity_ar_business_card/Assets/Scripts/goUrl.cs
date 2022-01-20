using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goUrl : MonoBehaviour
{
    public void ToGithub() {
        Application.OpenURL ("https://github.com/Brandixitor");
    }
    public void ToTwitter() {
        Application.OpenURL ("https://twitter.com/Brandixitor");
    }
    public void ToMail() {
        Application.OpenURL ("mailto:med.salah.bourouba@gmail.com");
    }
    public void ToLinkedin() {
        Application.OpenURL ("https://www.linkedin.com/in/med-salah-bourouba-5593731b6/");
    }
}
