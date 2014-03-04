	using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	
	public Transform Spawn;
	public float spawnTime = 0.1f;
	
	private int spawned = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > spawned * spawnTime){
			spawned++;
			Instantiate(Spawn, transform.position + transform.forward, Quaternion.identity);
		   
		}
	
	}
	
	
} 
/*
 T.4.03.2014 - Rasmus Engstrøm 
 Well, i found out how to edit the documents inside the github.com browser. 
*/
