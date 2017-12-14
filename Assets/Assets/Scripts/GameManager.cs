using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static GameManager _Instance;
	public enum _gameStates{Menu, Playing, Reset};
	[SerializeField] AudioSource s_backgroundMusic;
	[SerializeField] AudioClip s_deathSound;
	public _gameStates gameState = _gameStates.Playing;
	public GameObject _Player;
	public Text _pauseorplay;

	public Text tempo;
	public float tempojogo;

	public Canvas pause;
	public Button retornarJogo;
	public Button menuPrincipal;
	public Button pauseSair;

	public Canvas sairJogo;
	public Button sairSim;
	public Button sairNao;

	public Canvas gameOVER;
	public Button jogarSim;
	public Button jogarNao;



	void start (){
		pause = pause.GetComponent<Canvas> ();
		retornarJogo = retornarJogo.GetComponent<Button> ();
		menuPrincipal = menuPrincipal.GetComponent<Button> ();
		pauseSair = pauseSair.GetComponent<Button> ();
		sairJogo = retornarJogo.GetComponent<Canvas> ();
		sairSim = sairSim.GetComponent<Button> ();
		sairNao = sairNao.GetComponent<Button> ();
		gameOVER = gameOVER.GetComponent<Canvas> ();
		jogarSim = jogarSim.GetComponent<Button> ();
		jogarNao = jogarNao.GetComponent<Button> ();
		gameOVER.enabled = false;
		pause.enabled = false;
		pauseSair.enabled = false;

	}





	void Update () 
	{
		if (Time.timeScale == 1) {
			tempojogo += Time.deltaTime;
		}
		tempo.text = tempojogo.ToString ();


		
	}
	public void GamePause(){
		pause.enabled = true;
			Time.timeScale = 0;
			_pauseorplay.text = "PAUSE";

	}
	public void RetornarJogo(){
		pause.enabled = false;
		Time.timeScale = 1;
	}
	public void ChamarMenuDoJogo(){
		SceneManager.LoadScene ("Menu");
	}
	public void PauseSair(){
		sairJogo.enabled = true;
		sairSim.enabled = true;
		sairNao.enabled = true;
		retornarJogo.enabled = false;
		menuPrincipal.enabled = false;
		pauseSair.enabled = false;
	}
	public void SairSim(){
		Application.Quit();
	}
	public void SairNao(){
		sairJogo.enabled = false;
		sairSim.enabled = false;
		sairNao.enabled = false;
		retornarJogo.enabled = true;
		menuPrincipal.enabled = true;
		pauseSair.enabled = true;
	}
	public void GAMEOVER(){
		gameOVER.enabled = true;
		jogarSim.enabled = true;
		jogarNao.enabled = true;
		Time.timeScale = 0;
	}
	public void GameOverSim(){
		SceneManager.LoadScene ("Jogo");
	}
	public void GameOverNao(){
		SceneManager.LoadScene ("Menu");
	}

	}
