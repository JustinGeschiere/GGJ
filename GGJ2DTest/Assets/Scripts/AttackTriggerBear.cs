using UnityEngine;
using System.Collections;

public class AttackTriggerBear : MonoBehaviour {

	public bool attacking = false;
	public BoxCollider2D attackTrigger;
	private float attackTimer = 0;
	private float attackCd = 0.5f;
	// Use this for initialization

	void Awake () {
		attacking = false;
		attackTrigger.enabled = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && !attacking) {
			attacking = true;
			attackTimer = attackCd;

			attackTrigger.enabled = true;
		}

		if (attacking) {
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} else {
				attacking = false;
				attackTrigger.enabled = false;
			}
		}
	}
}