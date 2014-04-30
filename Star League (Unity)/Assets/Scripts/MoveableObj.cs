using UnityEngine;
using System.Collections;

public class MoveableObj : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
	


		Vector3 mousePos = Input.mousePosition; // creates a vector Var containing the mouseposition vector.
		Vector3 wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 0));
		// creates a vector containing the x and y of the mouseposition
		//compared to the camerascreen and not the computer screen.
		//Meaning instead of positioning the mouse 0,0,0 (bottom left of the computer screen)
		//We position 0,0,0 on the cameras position. 
		
		
		
		
		
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition ); 
		// create a ray from the Screen Point with the mousePosition as input.
		RaycastHit hit; // declare a hit condition. (also in the if statement)
		if( Physics.Raycast( ray, out hit ) ) // if the raycast hits do the following.
		{
			if( hit.collider.gameObject.CompareTag("MoveableObj") && Input.GetMouseButton(0) ) 
				// if the hit is on a collider placed on a gameObject with tag MoveAble Object
				// & you are pressing the left mousebutton
			{
				
				hit.collider.gameObject.transform.position = wantedPos; // transform the box into position wanted.
			}
		}

		Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;
	}
}
