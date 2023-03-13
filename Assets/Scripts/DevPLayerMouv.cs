using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevPLayerMouv : MonoBehaviour {
	public Rigidbody2D Player;
	public float speed;
	public float Jump;
	public float xInput;
	public	bool Grounded = false;
	public bool eatpower = false;
	public AudioSource JumpS;
	public AudioSource PowUp;
	// Use this for initialization
	void Start () {
		Player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		xInput = Input.GetAxis("Horizontal");
		//Move
		Player.velocity = new Vector2(xInput * speed ,Player.velocity.y);
		//Jump
		if (Input.GetKey(KeyCode.Space) && Grounded == true)
		{
			Player.velocity = new Vector2(Player.velocity.x, Jump);
			JumpS.Play();
		}
		if (Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene("TutuMap");
			Debug.Log("Restart, For The DEV");
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("Ground")){
			Grounded = true;
		}
	}
	void OnCollisionExit2D(Collision2D other)
	{
		if (other.collider.CompareTag("Ground")){
			Grounded = false;
		}
	}
	void OnTriggerEnter2D(Collider2D FruitOfPower)
	{
		if(FruitOfPower.gameObject.tag == "PowUp"){
			Destroy(FruitOfPower.gameObject);
			eatpower = true;
			PowUp.Play();
			Jump += 3;
		}
		if(FruitOfPower.gameObject.tag == "SpeedPowup"){
			Destroy(FruitOfPower.gameObject);
			eatpower = false;
			Jump = 10.5f;
			speed += 3.7f;
			PowUp.Play();
		}
	}
}