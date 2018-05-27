using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cityparallax : MonoBehaviour {

	public RawImage City;
	public float speed;


	// Update is called once per frame
	void Update () {


		Rect r = City.uvRect;
		r.x += speed;
		City.uvRect = r; 


	}
}
