using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Streetparallax : MonoBehaviour {

	public RawImage Street;
	public float speed;


	// Update is called once per frame
	void Update () {


		Rect r = Street.uvRect;
		r.x += speed;
		Street.uvRect = r; 


	}
}
