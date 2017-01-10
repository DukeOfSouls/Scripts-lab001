using UnityEngine;
using System.Collections;

public class RotateScriptR : MonoBehaviour {
	
	
	private Vector3 rotate = new Vector3 (0f,0f,250f);
	
	void Update () 
	{
		transform.Rotate(-rotate * Time.deltaTime);
	}
}
