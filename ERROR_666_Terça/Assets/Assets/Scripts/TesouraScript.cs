using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TesouraScript : MonoBehaviour {

	private NavMeshAgent nav;


	void Start(){
		nav = GetComponent<NavMeshAgent> ();
	}

	void Update(){
		nav.destination = GameObject.FindWithTag ("Player").transform.position;
	}

}
