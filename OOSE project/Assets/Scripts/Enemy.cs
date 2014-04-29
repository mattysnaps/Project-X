using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float maxHealth = 100;
	public float curHealth = 50;

	public float healthBarLength;

	void OnGUI(){
		GUI.color = Color.red; // Health bar text color is red
		GUI.Box(new Rect(860, 380, healthBarLength/10, 20), curHealth + "/" + maxHealth + " HP"); // the dimentions of the healthbar and the infomation it contains

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
