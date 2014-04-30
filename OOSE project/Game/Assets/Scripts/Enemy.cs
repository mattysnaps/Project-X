using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Health values
	public float maxHealth = 100;
	public float curHealth = 100;

	// Healthbar size
	public float healthBarLength;

	void OnGUI(){ //Makes a GUI box, used for helthbar
		GUI.color = Color.red; // Health bar text color is red
		GUI.Box(new Rect(10, 10, healthBarLength, 20), curHealth + "/" + maxHealth + " HP"); // the dimentions of the healthbar and the infomation it contains

		}

	public void TakeDamage(float dmg) {

		curHealth += dmg;

		if (curHealth >= 100) {
			curHealth = 100;
		}

		if (curHealth <= 0) {
			Die();
		}

		healthBarLength = Screen.width * (curHealth / (float)maxHealth);	
		}
	public void Die(){
		Destroy(gameObject);
		}
}
