using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {
	
	private Transform target;
	private float trackSpeed = 10;
	
	
	// Set target
	public void SetTarget(Transform t) {
		target = t;
	}
	
	// Track target
	void LateUpdate() {
		if (target) {
			float x = IncrementTowards(transform.position.x, target.position.x, trackSpeed);
			float y = IncrementTowards(transform.position.y, target.position.y, trackSpeed);
			transform.position = new Vector3(x,y, transform.position.z);
		}
	}
	
	// Increase current towards target by speed
	private float IncrementTowards(float curr, float target, float acc) {
		if (curr == target) {
			return curr;	
		}
		else {
			float dir = Mathf.Sign(target - curr); // curr (speed) going to be increased or decreased in order to get closer to target (speed)
			curr += acc * Time.deltaTime * dir;
			return (dir == Mathf.Sign(target-curr))? curr: target; // if curr (speed) has passed target (speed) then return target (speed), otherwise return curr (speed)
		}
	}
}
