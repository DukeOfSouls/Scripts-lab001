using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour 
{
	Vector3 size = new Vector3 (0.1f, 0f, 0.1f);

	private float speed = 30f;

	void Update() 
	{
		transform.localScale -= size*Time.deltaTime*speed;

		if(transform.localScale.x > 10f && transform.localScale.z > 10f)
		{
			size=-size;
		}

		if(transform.localScale.x < 0.3f && transform.localScale.z < 0.3f)
		{
			size=-size;
		}
	}
}
