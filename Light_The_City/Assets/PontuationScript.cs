﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuationScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col) 
	{
		ScoreScript.scoreValue += 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
