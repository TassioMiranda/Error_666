using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour {

	public Button VoltarText;

	void Start () {
		VoltarText = VoltarText.GetComponent<Button> ();
	}

	void Update () {
		
	}
	public void ChamaMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
