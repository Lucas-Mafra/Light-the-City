using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//movimento
	public float speed;
	private Rigidbody2D rb;
	public float jump;
	public float moveInput;


	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}

		
	 void FixedUpdate ()
	{

		moveInput = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (rb.velocity.x, jump);
		}
	}
}
