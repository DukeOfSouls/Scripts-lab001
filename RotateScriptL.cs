using UnityEngine;
using System.Collections;

public class RotateScriptL : MonoBehaviour {
	

	private Vector3 myVector = new Vector3 (0f,0f,250f);
	
	void Update () 
	{
		transform.Rotate(myVector*Time.deltaTime);
	}
}
