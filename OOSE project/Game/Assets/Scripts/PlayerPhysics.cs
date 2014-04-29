using UnityEngine;
using System.Collections;


[RequireComponent (typeof(BoxCollider))]
public class PlayerPhysics : MonoBehaviour {

	// Collision
	public LayerMask collisionMask;
	private BoxCollider collider;
	private Vector3 size;
	private Vector3 center;
	
	private float skin = .005f; // Space between the players collider and the ground, so that the raycast can detect proberly
	
	[HideInInspector] // Makes a variable not show up in the inspector but be serialized
	public bool grounded;

	private
	
	Ray ray;
	RaycastHit hit;
	
	void Start() {

		// Box collider
		collider = GetComponent<BoxCollider>();
		size = collider.size;
		center = collider.center;
	}

	public void Move(Vector2 moveAmount) {
		
		float deltaY = moveAmount.y;
		float deltaX = moveAmount.x;
		Vector2 pos = transform.position;
		
		// Check collisions above and below player
		grounded = false;
				// Loop creates 3 rays
		for (int i = 0; i<3; i ++) {
			float dir = Mathf.Sign(deltaY); // Direction
			float x = (pos.x + center.x - size.x/2) + size.x/2 * i; // Left, centre and then rightmost point of collider
			float y = pos.y + center.y + size.y/2 * dir; // Bottom of collider
			
			ray = new Ray(new Vector2(x,y), new Vector2(0,dir));
			
			if (Physics.Raycast(ray,out hit,Mathf.Abs(deltaY) + skin,collisionMask)) {
				// Get Distance between player and ground
				float dst = Vector3.Distance (ray.origin, hit.point);
				
				// Stop player's downwards movement after coming within skin width of a collider
				if (dst > skin) {
					deltaY = dst * dir + skin;
				}
				else {
					deltaY = 0;
				}
				
				grounded = true;
				
				break;
				
			}
		}
		
		
		// Check collisions left and right player
		for (int i = 0; i<3; i ++) {
			float dir = Mathf.Sign(deltaX);
			float x = pos.x + center.x + size.x/2 * dir;
			float y = pos.y + center.y - size.y/2 + size.y/2 * i;
			
			ray = new Ray(new Vector2(x,y), new Vector2(dir,0));
			
			if (Physics.Raycast(ray,out hit,Mathf.Abs(deltaX) + skin,collisionMask)) {
				// Get Distance between player and ground
				float dst = Vector3.Distance (ray.origin, hit.point);
				
				// Stop player's downwards movement after coming within skin width of a collider
				if (dst > skin) {
					deltaX = dst * dir + skin;
				}
				else {
					deltaX = 0;
				}
				break;
				
			}
		}

		// Check collision in players direction
		if (!grounded) {
			Vector3 playerDir = new Vector3 (deltaX , deltaY);
			Vector3 o = new Vector3 (pos.x + center.x + size.x / 2 * Mathf.Sign (deltaX), pos.y + center.y + size.y / 2 * Mathf.Sign (deltaY));
			ray = new Ray (o, playerDir);
			
			if (Physics.Raycast (ray, Mathf.Sqrt (deltaX * deltaX + deltaY * deltaY), collisionMask)) {
				grounded = true;
				deltaY = 0;
			}
		}

	
		
		Vector2 finalTransform = new Vector2(deltaX,deltaY); // Movement with the alterations included
		
		transform.Translate(finalTransform, Space.World);
	}
	
}
