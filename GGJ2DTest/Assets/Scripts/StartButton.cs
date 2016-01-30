using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
	
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			levelManager.loadLevel("Main");
		}
	}
}
