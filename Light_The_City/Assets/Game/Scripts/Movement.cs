using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;
	public float jump;
	public float moveInput;
	private bool isgrounded;
	public Transform check;
	public float checkRadius;
	public LayerMask Whatsground;
	public int jumpx;

	void Start () {

		rb = GetComponent<Rigidbody2D> ();
	}
		

	void FixedUpdate ()
	{
		isgrounded = Physics2D.OverlapCircle (check.position, checkRadius, Whatsground);

		moveInput = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);
		if(Input.GetKeyDown(KeyCode.UpArrow)&& jumpx > 0){
			rb.velocity = Vector2.up * jump;
	}
  } 
}