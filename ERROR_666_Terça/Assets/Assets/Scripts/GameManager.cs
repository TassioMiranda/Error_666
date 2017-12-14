using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager _Instance;
	public enum _gameStates{Menu, Playing, Reset};
	[SerializeField] AudioSource s_backgroundMusic;
	[SerializeField] AudioClip s_deathSound;
	public _gameStates gameState = _gameStates.Playing;
	public GameObject _Player;
	private bool _pausegame = false;
	public Text _pauseorplay;

	void Awake ()
	{
		DontDestroyOnLoad (_Instance);

		if (_Instance == null) {
			_Instance = this;
		}

		if (_Instance == this){
			Destroy (_Instance);
		}
			
	}

	void Update () 
	{
		switch(gameState)
		{
		case _gameStates.Menu:

			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				
			}

			break;
		case _gameStates.Playing:
			
			_pauseorplay.text = "REC";

			break;


		case _gameStates.Reset:
			
			break;
		}
	}
	/*public void GamePause(){
		if (_pausegame == false) {
			_pausegame = true;
			Time.timeScale = 0;
			_pauseorplay.text = "PAUSE";
				
		}

		if (_pausegame == true) {
			_pausegame = false;
			Time.timeScale = 1;
		}
	}*/
}
