using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    public AudioSource Click;
    public void Reset()
    {
        SceneManager.LoadScene("MainMenu");
        Click.Play();
    }
}
