using UnityEngine;
using System.Collections;

public class DestroyRangedAttack : MonoBehaviour {

	void OnTriggerEnter(Collider r){ //Destroy game object in collision with object tagged "Enemy"
		if (r.tag == "Enemy") {		
			Destroy(gameObject);
		}
	}
}
