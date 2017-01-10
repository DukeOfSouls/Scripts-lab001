using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour 
{
	void OnTriggerEnter(Collider col)
	{	
		if(col.tag == "Door1")
		{
			Application.LoadLevel("light puzzel");
		}

		if(col.tag == "Door2")
		{
			Application.LoadLevel("pattern puzzel");
		}

		if(col.tag == "Door3")
		{
			Application.LoadLevel("moving puzzel");
		}

		if(col.tag == "Door4")
		{
			Application.LoadLevel("search puzzel");
		}

		if(col.tag == "Goal2")
		{
			Application.LoadLevel("start area2");
		}

		if(col.tag == "Goal3")
		{
			Application.LoadLevel("start area3");
		}

		if(col.tag == "Goal4")
		{
			Application.LoadLevel("start area4");
		}
	}
}