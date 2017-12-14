using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject tesoura;
	public Transform[] tvs;
	public float initalDelay;
	public float difficulty;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnScissor ());
	}

	IEnumerator SpawnScissor(){
		while (true) {
			yield return new WaitForSeconds (initalDelay);
			initalDelay = initalDelay / difficulty;
			Instantiate (tesoura, tvs [Random.Range (0, tvs.Length)].position, Quaternion.identity);
		}
	}

}
