using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {

	[SerializeField] float _bolaForce;
	[SerializeField] Rigidbody _rigidBody;
	[SerializeField] float _bolaJumpForce;
	private GameManager GameManager;
	void Start()
	{
		GameManager = FindObjectOfType (typeof(GameManager)) as GameManager;
	}

	void FixedUpdate () 
	{

		float horizontalMove = Input.GetAxis ("Horizontal");
		float VerticalMove = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontalMove, 0, VerticalMove);

		_rigidBody.AddForce (movement * _bolaForce);

		Ray myRay = new Ray (transform.position, Vector3.down);

		Debug.DrawRay (transform.position, Vector3.down);

		if (Physics.Raycast (myRay, 0.5f)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				_rigidBody.AddForce (Vector3.up * (_bolaForce * _bolaJumpForce));
			}
		}
		
		if (Input.GetKeyDown (KeyCode.P)) {
			GameManager.GamePause ();
		}
	}
}
