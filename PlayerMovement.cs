﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
		
	public float forwardForce = 500f;
	public float sidewaysForce = 500f;


	// Update is called once per frame
	void FixedUpdate ()
	{
		// Forward Force
		if (Input.GetKey ("w")) 
		{
			rb.AddForce (0, 0, forwardForce * Time.deltaTime);
		}

		// if osio
		// player movement
		if ( Input.GetKey("d"))
		{

			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}
		if ( Input.GetKey("a"))
		{

			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}

		if ( Input.GetKey("s"))
		{

			rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
		}


		// Player movement done

	}
}