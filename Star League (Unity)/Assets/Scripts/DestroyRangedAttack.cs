using UnityEngine;
using System.Collections;

public class DestroyRangedAttack : MonoBehaviour {

	void OnTriggerEnter(Collider r){
		if (r.tag == "Enemy") {		
			Destroy(gameObject);
		}
	}
}
