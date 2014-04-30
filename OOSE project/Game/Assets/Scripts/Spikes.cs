using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

	void OnTriggerEnter(Collider c){ //Destroy game object in collision with object tagged "Enemy" and subtracts 10 to curHealth in the enemy script
		if (c.tag == "Player") {
			c.GetComponent<Enemy>().TakeDamage(-10);	
		}
	}
}
