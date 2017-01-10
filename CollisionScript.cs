using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public DoorScript DS;

	void Start () 
	{
		DS = GameObject.Find("Door").GetComponent<DoorScript>();
	}
	

	void StopScripts () 
	{
		DS.enabled = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Key")
		{
			DS.enabled = true;
			Invoke("StopScripts", 2f);
		}

		if(col.tag == "Cross")
		{
			Application.LoadLevel(Application.loadedLevel);
		}

	}
}
