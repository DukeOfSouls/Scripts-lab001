using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public float speed;
	public float jump;
	public bool isJumping = false;
	float score = 0;
	
	void JumpingTime ()
	{
		isJumping = false;
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
		GetComponent<Rigidbody>().AddForce (movement  *speed*  Time.deltaTime);
		Jump();

		if(score == 3)
		{
			Debug.Log("Score is 3!");
		}

		if(transform.position.y < 0)
		{
			Application.LoadLevel(Application.loadedLevel);
		}

	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Pickup")
		{
			other.gameObject.SetActive(false);
			score =+ 1;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Terrain" || other.gameObject.tag == "S1" || other.gameObject.tag == "S2" || other.gameObject.tag == "S3" || other.gameObject.tag == "S4")
		{
			isJumping = false;
		}

	}
	
	void Jump()
	{
		if(Input.GetKeyDown("space") && isJumping == false)
		{
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
			isJumping = true;
		}
	}
}