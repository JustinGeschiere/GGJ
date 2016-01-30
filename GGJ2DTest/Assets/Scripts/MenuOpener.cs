using UnityEngine;
using System.Collections;

public class MenuOpener : MonoBehaviour {
	
	public GameObject menu;
	public ExitButton button;
	
	void Start () {
		
	}
	
	void Update () {
		
	}
	
	void OnMouseDown () 
	{
		if (menu.activeSelf == false)
		{
			menu.SetActive(true);
		}
		else if (menu.activeSelf == true)
		{    
			menu.SetActive(false);
		}
	}
}
			
			