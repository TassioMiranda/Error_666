﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	
	[SerializeField] Transform target;
	[SerializeField] float smoothSpeed;
	[SerializeField] Vector3 offset;

	void Awake() 
	{
		//smoothSpeed = 0.125f;
	}

	void FixedUpdate () 
	{
		Vector3 desiredPosition = target.position + offset;
		Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = SmoothedPosition ;

	}
}
