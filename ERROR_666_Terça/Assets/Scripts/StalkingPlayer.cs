using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkingPlayer : MonoBehaviour {
	
	[SerializeField] GameObject target;
	[SerializeField] float yDistance;
	[SerializeField] float smooth = 0.25f;
	private Vector3 velocity = Vector3.one;

	void FixedUpdate () {

		Vector3 desiredPosition = new Vector3 (target.transform.position.x, target.transform.position.y + yDistance, target.transform.position.z);
		Vector3 SmoothedPosition = Vector3.SmoothDamp (transform.position, desiredPosition, ref velocity, smooth);
		transform.position = SmoothedPosition;
	}
}
