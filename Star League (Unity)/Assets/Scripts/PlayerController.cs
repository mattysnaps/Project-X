using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : Enemy {

	private string axisName = "Horizontal";

	// Player Handling
	public float gravity = 20;
	public float speed = 8;
	public float acceleration = 30;
	public float jumpHeight = 12;
	
	private float currentSpeed;
	private float targetSpeed;
	private Vector2 amountToMove;
	
	private PlayerPhysics playerPhysics;

	// Player animation
	private Animator animator;

	void Start () 
	{
		// Player health bar
		healthBarLength = Screen.width;

		playerPhysics = GetComponent<PlayerPhysics>();

		// Initial animation
		animator = GetComponent<Animator> ();

	}
	
	void Update () 
	{
		
		// Checks if the player is in contact with the ground
		if (playerPhysics.grounded) {
			amountToMove.y = 0;
			
			// Jump
			if (Input.GetButtonDown("Jump")) {
				amountToMove.y = jumpHeight;	
			}
		}
		
		// Input
		targetSpeed = Input.GetAxisRaw(axisName) * speed;
		currentSpeed = IncrementTowards(currentSpeed, targetSpeed,acceleration);
		
		// Set amount to move
		amountToMove.x = currentSpeed;
		amountToMove.y -= gravity * Time.deltaTime; 
		playerPhysics.Move(amountToMove * Time.deltaTime);

		// Animation
		animator.SetFloat ("Speed", Mathf.Abs(currentSpeed));
			//Face direction
		float moveDir = Input.GetAxis (axisName);
		transform.eulerAngles = (moveDir > 0) ? Vector3.up * 180 : Vector3.zero;

	}
	
	// Increase n towards target by speed
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
