using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerByTime : MonoBehaviour {

	public float lifetime;

	// Script para destruir os Obstaculos depois de um tempo de vida
	void Start () 
	{
		Destroy (gameObject, lifetime); 
	}

}
