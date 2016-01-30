﻿using UnityEngine;
using System.Collections;

public class AttackTrigger : MonoBehaviour {
	// Use this for initialization

	void OnTriggerEnter2D (Collider2D col) {
		if (col.CompareTag("Stone")) {
			col.SendMessageUpwards ("BearHit");
		}
	}


}
