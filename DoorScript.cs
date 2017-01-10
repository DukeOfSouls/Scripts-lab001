using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour 
{

	Vector3 move = new Vector3(0f, -1.1f, 0f);

	public DoorScript DS;

	void Start () 
	{
		DS = GameObject.Find("Door").GetComponent<DoorScript>();
		DS.enabled = false;
	}
	

	void Update () 
	{
		transform.position +=move * Time.deltaTime;
	}
}
