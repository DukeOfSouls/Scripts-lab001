using UnityEngine;
using System.Collections;

public class CubesRScript : MonoBehaviour 
{
		
		private float speed = -2.5f;
		
		void Update () 
		{
			transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
		}
		
		void OnTriggerEnter(Collider col)
		{
			if(col.tag == "Wall")
			{
				speed=-speed;
			}
		}		
}