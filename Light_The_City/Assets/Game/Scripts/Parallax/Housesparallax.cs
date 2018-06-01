using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Housesparallax : MonoBehaviour {

	public RawImage Houses;
	public float speed;


	// Update is called once per frame
	void Update () {


		Rect r = Houses.uvRect;
		r.x += speed;
		Houses.uvRect = r; 


	}
}
