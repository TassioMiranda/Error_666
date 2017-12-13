using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereJumpPhysics : MonoBehaviour {

	[SerializeField] float _FallMultiplier;
	//[SerializeField] float _LowJumpMultiplier;
	private Rigidbody _myRb;

	void Awake() 
	{
		_myRb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		if (_myRb.velocity.y < 0)
		{
			_myRb.velocity += Vector3.up * Physics.gravity.y * (_FallMultiplier - 1) * Time.deltaTime;

		//} else if (_myRb.velocity.y > 0 && !Input.GetKey (KeyCode.Space)) 
		//{
		//	_myRb.velocity += Vector3.up * Physics.gravity.y * (_LowJumpMultiplier - 1) * Time.deltaTime;

		}
	}
}
