using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public Rigidbody rangedAttackPreFab;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			RangedAttack();
		}
	
	}
	void RangedAttack(){  // Can "attach" a prefab and add force to it (makes it shoot)
		Rigidbody rAttPreFab = Instantiate (rangedAttackPreFab, transform.position, Quaternion.identity) as Rigidbody;		   
		rAttPreFab.rigidbody.AddForce(Vector3.right * 500);
	}

}
