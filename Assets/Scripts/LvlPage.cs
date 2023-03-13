using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlPage : MonoBehaviour
{
    public AudioSource Click;
    public void Reset()
    {
        SceneManager.LoadScene("LVLSPAGE");
        Click.Play();
    }
}
