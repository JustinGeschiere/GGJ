using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	RaycastHit hit; 
	Ray ray; 
	Transform target;
	
	void Start () {
		
	}
	
	void Update (){
		
	}
	
	public void quitApplication (){
		Application.Quit();
	} 
}
