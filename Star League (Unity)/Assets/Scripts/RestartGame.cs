using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour {

	void Start () 
	{
	}
	
	// This code makes a "RESTART" button in the lower right corner
	
	void OnGUI()
	{
		
		if (GUI.Button(new Rect(Screen.width/2+550, 700, 75, 50),"RESTART"))
		{
			Application.LoadLevel(1);
		}                  
		
	}	
}
