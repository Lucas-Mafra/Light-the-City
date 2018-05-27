using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cloudsparallax : MonoBehaviour {

	public RawImage Clouds;
	public float speed;


	// Update is called once per frame
	void Update () {


		Rect r = Clouds.uvRect;
		r.x += speed;
		Clouds.uvRect = r; 


	}
}
