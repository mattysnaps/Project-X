﻿using UnityEngine;
using System.Collections;

public class LockZ : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;
	}
}
