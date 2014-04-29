using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	 				
	void OnGUI()
	{
                       
		if (GUI.Button(new Rect(Screen.width/2+500, 15, 150, 100),"BACK TO MAIN MENU"))
		{
		Application.LoadLevel(0);
		}                  
			
	}	
}

