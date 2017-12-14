using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Canvas sairMenu;
	public Button startText;
	public Button sairText;
	public Button creditosText;
	void Start () {
		sairMenu = sairMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		sairText = sairText.GetComponent<Button> ();
		creditosText = creditosText.GetComponent<Button> ();
		sairMenu.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ApertarSair(){
		sairMenu.enabled = true;
		startText.enabled = false;
		sairMenu.enabled = false;
	}
	public void NaoApertado(){
		sairMenu.enabled = false;
		startText.enabled = true;
		sairMenu.enabled = true;
}
	public void ComecarJogo(){
		SceneManager.LoadScene("Jogo");
		}
	public void SairJogo(){
		Application.Quit();
	}
	public void ChamaCreditos(){
		SceneManager.LoadScene ("Creditos");
	}
}
