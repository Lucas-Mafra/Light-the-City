using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;
	public float jump;
	public float move;


	void Start () {

		rb = GetComponent<Rigidbody2D> ();
	}
		

	void FixedUpdate()
	{



		move = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (move * speed, rb.velocity.y);

	}
}
