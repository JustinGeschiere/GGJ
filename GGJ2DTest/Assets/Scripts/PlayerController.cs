using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 5f;
	public bool bearUnlocked = true;
	public bool monkeyUnlocked = true;
	public bool birdUnlocked = true;
	public bool unknownUnlocked = true;
	private bool facingRight = false;
	public GameObject bear;
	public GameObject human;
	public GameObject monkey;
	public GameObject bird;
	public GameObject unknown;
	public float morphCD = 0f;
	// Use this for initialization
	void Start () {
		//human.gameObject.SetActive (true);
		//bear.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!(morphCD <= 0f)) {
			morphCD = (morphCD - Time.deltaTime);
			return;
		}
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (maxSpeed * moveHor, maxSpeed * moveVer);

		if (moveHor > 0 && facingRight){
			Flip ();
		} else if (moveHor < 0 && !facingRight){
			Flip ();
		}
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha1) && bearUnlocked && morphCD <= 0) {
			maxSpeed = 3f;
			bear.gameObject.SetActive (true);
			human.gameObject.SetActive (false);
			monkey.gameObject.SetActive (false);
			bird.gameObject.SetActive (false);
			unknown.gameObject.SetActive (false);
			morphCD = 1f;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2) && monkeyUnlocked && morphCD <= 0) {
			maxSpeed = 5f;
			bear.gameObject.SetActive (false);
			human.gameObject.SetActive (false);
			monkey.gameObject.SetActive (true);
			bird.gameObject.SetActive (false);
			unknown.gameObject.SetActive (false);
			morphCD = 1f;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3) && birdUnlocked && morphCD <= 0) {
			maxSpeed = 7f;
			bear.gameObject.SetActive (false);
			human.gameObject.SetActive (false);
			monkey.gameObject.SetActive (false);
			bird.gameObject.SetActive (true);
			unknown.gameObject.SetActive (false);
			morphCD = 1f;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha4) && unknownUnlocked && morphCD <= 0) {
			maxSpeed = 4f;
			bear.gameObject.SetActive (false);
			human.gameObject.SetActive (false);
			monkey.gameObject.SetActive (false);
			bird.gameObject.SetActive (false);
			unknown.gameObject.SetActive (true);
			morphCD = 1f;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha5) && morphCD <= 0) {
			maxSpeed = 5f;
			bear.gameObject.SetActive (false);
			human.gameObject.SetActive (true);
			monkey.gameObject.SetActive (false);
			bird.gameObject.SetActive (false);
			unknown.gameObject.SetActive (false);
			morphCD = 1f;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		}

	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
