using UnityEngine;
using System.Collections;

public class PlusHealth : MonoBehaviour {

	void OnTriggerEnter(Collider c){ //Destroy game object in collision with object tagged "Enemy" and adds 10 to curHealth in the enemy script
		if (c.tag == "Player") {
			c.GetComponent<Enemy>().TakeDamage(10);	

			Destroy(gameObject);
		}
	}
}
