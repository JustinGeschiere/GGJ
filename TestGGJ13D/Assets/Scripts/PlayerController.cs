using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxSpeed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");


		GetComponent<Rigidbody> ().velocity = new Vector3 (moveHor * maxSpeed,GetComponent<Rigidbody> ().velocity.y , moveVer * maxSpeed);

	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			print ("1_pressed");
		}



	}
}
