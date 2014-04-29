using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	float startPos;
	float endPos;

	public float distanceToMove = 10;
	public float speed = 2;

	bool moveRight;

	void Awake(){
		startPos = transform.position.x;
		endPos = startPos + distanceToMove;
		}

	// Update is called once per frame
	void Update () {
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
