using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float posicaoX;
	private float posicaoY;

	[SerializeField] GameObject _tesouraPrefab;
	private GameManager _gameManager;
	[SerializeField] float _Frequencia;
	private float frequencia;


	void Start () 
	{
		_gameManager = FindObjectOfType (typeof(GameManager)) as GameManager;

		_Frequencia = Time.deltaTime;
	}

	void Update () 
	{
		
	}

	public void Spawn()
	{
			
	}
}
