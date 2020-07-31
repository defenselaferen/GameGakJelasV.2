using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Make The Rigid Body To The Physic
	public Rigidbody Rb;

	// Make The Variable
	public float speed = 3000f;
	public float Jump = 900f;
	private bool IsJump = false;
	
	void Update ()
	{
		if(Input.GetKey("a"))
		{
			Rb.AddForce(0, 0, -speed * Time.deltaTime);
		}
		if(Input.GetKey("d"))
		{ 
			Rb.AddForce(0, 0, speed * Time.deltaTime);
		}
		if(Input.GetButtonDown("Jump") && IsJump == false)
		{
			Rb.AddForce(new Vector3(0, Jump));
			IsJump = true;
		}

		if(Rb.position.y < -12.1)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	void OnCollisionEnter (Collision other)
	{
		if(other.collider.tag == "Platform")
		{
			IsJump = false;
		}
	}
}
