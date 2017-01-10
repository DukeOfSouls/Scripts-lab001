using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour 
{
	void Update () 
	{
		transform.Rotate(0f,0f,-3f);
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
