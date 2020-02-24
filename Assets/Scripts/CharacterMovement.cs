using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour
{
	public float speed;
	public float jump;
	public float checkRadius;
	public int doubleJumpValue;
	public int health = 2;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	public Animator anim;

	private int doubleJump;
	private Rigidbody2D rb;
	private bool isGrounded;



	void Start()
	{
		doubleJump = doubleJumpValue;
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (isGrounded == true)
		{
			doubleJump = doubleJumpValue;
			anim.Play("Running");
		}
		if (isGrounded == false)
		{
			anim.Play("Jumping");

		}
		if (isGrounded == false && doubleJump > 0 && Input.GetButtonDown("Jump"))
		{
			anim.Play("Running");
			anim.Play("Jumping");
		}

		//move = Input.GetAxis("Horizontal");
		//rb.velocity = new Vector2(move * speed, rb.velocity.y);
		if (Input.GetButtonDown("Jump") && doubleJump > 0)
		{
			rb.AddForce(new Vector2(rb.velocity.x, jump));
			doubleJump--;
		}
		else if (Input.GetButtonDown("Jump") && doubleJump == 0 && isGrounded == true)
		{
			rb.AddForce(new Vector2(rb.velocity.x, jump));
		}


	}

	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
	}
}
