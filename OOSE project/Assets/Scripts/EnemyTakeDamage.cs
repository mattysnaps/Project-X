using UnityEngine;
using System.Collections;

public class EnemyTakeDamage : MonoBehaviour {

	void OnTriggerEnter(Collider a){
		if (a.tag == "RangedAttack") {		
			Destroy(gameObject);
		}
	}
}
