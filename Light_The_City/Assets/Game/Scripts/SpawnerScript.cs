﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject enemy;
	float rand;
	Vector2 wheretospawn;
	public float spawnrate = 2f;
	float nextspawn = 0.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time > nextspawn) 
		{
			nextspawn = Time.time + spawnrate;
			rand = Random.Range (-8.4f, 8.4f);
			wheretospawn = new Vector2 (rand, transform.position.y);
			Instantiate (enemy, wheretospawn, Quaternion.identity);
		}
	}
}
