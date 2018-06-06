using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//movimento
	public float speed;
	private Rigidbody2D rb;
	public float jump;
	public float moveInput;
	private bool OnGround;
	private bool Jumping;


	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}

		
	 void FixedUpdate ()
	{

		moveInput = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);

		if (OnGround == true && Jumping == true) {
			rb.velocity = new Vector2 (rb.velocity.x, jump);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Jumping = true;
		} 

		else 
		{
			Jumping = false;
		}
	}



	void OnCollisionStay2D(Collision2D ground)
	{
		if (ground.gameObject.tag == "Ground") {
			OnGround = true;
		}

	}

	void OnCollisionExit2D() 
	{
		OnGround = false;
	}
}
