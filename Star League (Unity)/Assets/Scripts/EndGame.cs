using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") 
		{
			Application.LoadLevel(0);
		}

	}	
}
