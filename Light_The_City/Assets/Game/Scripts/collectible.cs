using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectible : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
		
		Destroy(gameObject);
	} 



}
