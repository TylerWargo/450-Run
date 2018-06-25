using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{
	public float movementSpeed;

	public float jumpForce;
	public bool doubleJumped;
	public AudioSource jumpSound;

	public Transform groundCheck;
	public float groundCheckRadius;
	public bool grounded;
	public LayerMask groundID;

	private Rigidbody2D playerRB;
	private Collider2D playerCol;

	private Animator playerAnim;

	public void Awake()
	{
		playerRB = GetComponent<Rigidbody2D> ();
		playerCol = GetComponent<Collider2D> ();
		playerAnim = GetComponent<Animator> ();
	}

	public void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, groundID);
	}

	public void Update()
	{
		grounded = Physics2D.IsTouchingLayers (playerCol, groundID);
		playerAnim.SetBool ("Grounded", grounded);

		//Move Right (Constantly)
		playerRB.velocity = new Vector2 (movementSpeed, playerRB.velocity.y);

		//Jump & Input
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) 
		{
			if (grounded || !doubleJumped) 
			{
				jumpSound.Play ();
				playerRB.velocity = new Vector2 (playerRB.velocity.x, jumpForce);
				doubleJumped = !grounded;
			} 
			else if (grounded) 
			{
				doubleJumped = false;
			}
		}
	}
}