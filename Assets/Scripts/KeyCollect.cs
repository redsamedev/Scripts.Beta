using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCollect : MonoBehaviour
{
    public Rigidbody2D Player;
    public GameObject WinImage;
    public GameObject NextLVL;
    public GameObject Exit;
    public GameObject LVLPage;
    public GameObject Retry;
    public GameObject TextKeynotFound;
    public GameObject TextLose;
    public bool hadkey = false;
    public AudioSource KeyCollectit;
    public MonoBehaviour PLM;
    void Start()
    {
        PLM.enabled = true;
        Player.GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Key"){
            Destroy(other.gameObject);
            hadkey = true;
            KeyCollectit.Play();
        }
    }
    void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "YOUI" && hadkey == true){
			WinImage.SetActive(true);
            NextLVL.SetActive(true);
            LVLPage.SetActive(true);
            Exit.SetActive(true);
            Retry.SetActive(true);
            PLM.enabled = false;
            Player.velocity = new Vector2(0, 0);
		}
        else if (other.gameObject.tag == "YOUI" && hadkey == false)
        {
            WinImage.SetActive(true);
            LVLPage.SetActive(true);
            Exit.SetActive(true);
            NextLVL.SetActive(false);
            TextKeynotFound.SetActive(true);
            Retry.SetActive(true);
            PLM.enabled = false;
            Player.velocity = new Vector2(0, 0);
        }
        else if (other.gameObject.tag == "Losing")
        {
            Destroy(gameObject);
            Retry.SetActive(true);
            WinImage.SetActive(true);
            Exit.SetActive(true);
            TextLose.SetActive(true);
            LVLPage.SetActive(true);
            Debug.Log("It Works");
        }
	}
}
