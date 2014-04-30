using UnityEngine;
using System.Collections;

public class EnemyTakeDamage : MonoBehaviour {

	void OnTriggerEnter(Collider a){ //Destroy game object in collision with object tagged "RangedAttack"
		if (a.tag == "RangedAttack") {		
			Destroy(gameObject);
		}
	}
}
