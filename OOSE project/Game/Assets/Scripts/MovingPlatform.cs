using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	// Position variables
	float startPos;
	float endPos;
	// Movement variables
	public float distanceToMove = 10;
	public float speed = 2;

	bool moveRight;

	void Awake(){
		startPos = transform.position.x;
		endPos = startPos + distanceToMove;
		}

	void Update () {  // Moves right until it has travelled the distance from starPos
		if (moveRight) {
			rigidbody.position += Vector3.right * speed * Time.deltaTime;
		}
		if (rigidbody.position.x >= endPos) {
			moveRight = false;
		}
		if (!moveRight) {
			rigidbody.position -= Vector3.right * speed * Time.deltaTime;
		}
		if (rigidbody.position.x <= startPos) {
			moveRight = true;
		}
	}
}
