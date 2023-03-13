using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public AudioSource Click;
   public void Reset()
   {
    SceneManager.LoadScene("TutuMap");
    Click.Play();
   }
}
