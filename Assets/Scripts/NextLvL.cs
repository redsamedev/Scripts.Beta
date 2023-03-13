using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvL : MonoBehaviour
{
    public AudioSource Click;
    public void Reset()
    {
        SceneManager.LoadScene("LVL1");
        Click.Play();
    }
}
