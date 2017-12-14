using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public GameObject Player;
	private GameManager GameManager;

	void Start () {
		GameManager = FindObjectOfType (typeof(GameManager)) as GameManager;
	}

	void OnTriggerEnter(Collider other){
		GameManager.GAMEOVER ();
		Destroy (Player);
	}
}
