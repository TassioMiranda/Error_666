using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float posicaoX;
	private float posicaoY;

	[SerializeField] Gameobject _tesouraPrefab;
	private GameManager _gameManager;
	[SerializeField] float _Frequencia;
	private float frequencia;


	void Start () 
	{
		_gameManager = FindObjectOfType (typeof(GameManager)) as GameManager;

		_Frequencia = 
	}

	void Update () 
	{
		
	}

	public void Spawn()
	{
			
	}
}
