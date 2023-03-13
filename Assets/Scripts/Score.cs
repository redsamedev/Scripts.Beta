using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public AudioSource YCOllectit;
    public Text ScoreT;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        ScoreT.text = "Coins: " + ScoreNum;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.tag == "Coin"){
            Destroy(coin.gameObject);
            ScoreNum++;
            ScoreT.text = "Coins: " + ScoreNum;
            YCOllectit.Play();
        }
    }
}
