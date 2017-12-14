using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float _moveSpeed;
	[SerializeField] Rigidbody _rigidBody;

	void FixedUpdate ()
	{
		float horizontalMove = Input.GetAxis("Horizontal");
		float VertcialMove = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (horizontalMove, 0, VertcialMove);

		 _rigidBody.AddForce (movement * _moveSpeed);
	}
}

