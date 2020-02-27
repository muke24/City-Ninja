using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	public float speed;
	public float jump;
	public float checkRadius;
	public int doubleJumpValue;
	public int health = 3;
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

		#region Health Hearts
		if (health == 3)
		{
			heart3.SetActive(true);
			heart2.SetActive(true);
			heart1.SetActive(true);
		}
		if (health == 2)
		{
			heart3.SetActive(false);
			heart2.SetActive(true);
			heart1.SetActive(true);
		}
		if (health == 1)
		{
			heart3.SetActive(false);
			heart2.SetActive(false);
			heart1.SetActive(true);
		}
		if (health == 0)
		{
			heart3.SetActive(false);
			heart2.SetActive(false);
			heart1.SetActive(false);
		}
		#endregion

        if(health < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
	}

	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
	}
}
