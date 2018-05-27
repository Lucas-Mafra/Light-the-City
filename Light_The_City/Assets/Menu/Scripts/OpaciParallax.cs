using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpaciParallax : MonoBehaviour {

	public RawImage Opaci;
	public float speed;


	// Update is called once per frame
	void Update () {


		Rect r = Opaci.uvRect;
		r.x += speed;
		Opaci.uvRect = r; 


	}
}

