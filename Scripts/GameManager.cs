﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager _Instance;
	public enum _gameStates{Menu, Playing, Reset, Pause};
	[SerializeField] AudioSource s_backgroundMusic;
	[SerializeField] AudioClip s_deathSound;
	public _gameStates gameState = _gameStates.Menu;
	private bool _pausegame;

	void Awake ()
	{
		#region
		DontDestroyOnLoad (_Instance);

		if (_Instance == null) 
		{
			_Instance = this;
		}

		if (_Instance == this)
		{
			Destroy (_Instance);
		}
		#endregion

		_pausegame = false;
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
			break;
		case _gameStates.Pause:
			break;
		case _gameStates.Reset:
			break;
		}
	}
}
