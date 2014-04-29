using UnityEngine;
using System.Collections;

public class PlusHealth : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if (c.tag == "Player") {
			c.GetComponent<Enemy>().TakeDamage(10);	

			Destroy(gameObject);
		}
	}
}
