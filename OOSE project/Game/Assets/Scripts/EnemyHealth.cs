using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public float curEnemyHealth = 10;
	
	public void EnemyTakeDamage(float dmgTaken) {
		
		curEnemyHealth -= dmgTaken;
				
		if (curEnemyHealth <= 0) {
			Destroy(gameObject);
		}	
	}
}
