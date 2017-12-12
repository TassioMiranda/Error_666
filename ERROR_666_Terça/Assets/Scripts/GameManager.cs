using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager _Instance;

	void Awake () {
		#region
		DontDestroyOnLoad (_Instance);

		if (_Instance != null) {
			Destroy (_Instance);
		}

		if (_Instance == this) {
		}
		#endregion
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
