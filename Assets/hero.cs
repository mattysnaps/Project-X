using UnityEngine;
using System.Collections;

public class hero : MonoBehaviour {
	
	public float moveSpeed = 1000.0f;
	// Use this for initialization
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//if(Input.GetKey(KeyCode.B)){
		//	Instantiate(Exp, transform.position, Quaternion.identity);
		//}
		
		if(Input.GetMouseButton(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Vector3 mousePositionInWorld = ray.origin+ray.direction*
				Vector3.Distance(Camera.main.transform.position,transform.position);
			
			mousePositionInWorld.y = 0;

			Vector3 diff = mousePositionInWorld - transform.position;
			
			rigidbody.AddForce(diff*Time.deltaTime*moveSpeed);
		}
		
		if (Input.GetKey(KeyCode.A))
			rigidbody.AddForce(-10.0f * Time.deltaTime*moveSpeed,0,0);
		
		if (Input.GetKey(KeyCode.D))
			rigidbody.AddForce(10.0f * Time.deltaTime*moveSpeed,0,0);
	}
}



	
// transform.position = Vector3.Lerp(transform.position, center, 0.2f);