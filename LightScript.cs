using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	public DoorScript DS;
	public LightScript LS;

	public float sphereSize = 1f;

	public GameObject lightplateA;
	public GameObject lightplateB;
	public GameObject lightplateC;
	public GameObject lightplateD;
	public GameObject lightplateE;
	public GameObject lightplateF;
	public GameObject lightplateG;
	public GameObject lightplateH;
	public GameObject lightplateI;
	public GameObject lightplateJ;
	public GameObject lightplateK;
	public GameObject lightplateL;
	public GameObject lightplateM;
	public GameObject lightplateN;
	public GameObject lightplateO;
	public GameObject lightplateP;
	public GameObject lightplateQ;
	public GameObject lightplateR;
	public GameObject lightplateS;
	public GameObject lightplateT;
	public GameObject lightplateU;
	public GameObject lightplateV;
	public GameObject lightplateW;
	public GameObject lightplateX;
	public GameObject lightplateY;

	public Light L1;
	public Light L2;
	public Light L3;
	public Light L4;
	public Light L5;
	public Light L6;
	public Light L7;
	public Light L8;
	public Light L9;
	public Light L10;
	public Light L11;
	public Light L12;
	public Light L13;
	public Light L14;
	public Light L15;
	public Light L16;
	public Light L17;
	public Light L18;
	public Light L19;
	public Light L20;
	public Light L21;
	public Light L22;
	public Light L23;
	public Light L24;
	public Light L25;

	
	void Start ()
	{
		DS = GameObject.Find("Door").GetComponent<DoorScript>();
		LS = GameObject.Find ("Player").GetComponent<LightScript>();
		L1 = GameObject.Find ("LightplateA").GetComponent<Light>();
		L2 = GameObject.Find ("LightplateB").GetComponent<Light>();
		L3 = GameObject.Find ("LightplateC").GetComponent<Light>();
		L4 = GameObject.Find ("LightplateD").GetComponent<Light>();
		L5 = GameObject.Find ("LightplateE").GetComponent<Light>();
		L6 = GameObject.Find ("LightplateF").GetComponent<Light>();
		L7 = GameObject.Find ("LightplateG").GetComponent<Light>();
		L8 = GameObject.Find ("LightplateH").GetComponent<Light>();
		L9 = GameObject.Find ("LightplateI").GetComponent<Light>();
		L10 = GameObject.Find ("LightplateJ").GetComponent<Light>();
		L11 = GameObject.Find ("LightplateK").GetComponent<Light>();
		L12 = GameObject.Find ("LightplateL").GetComponent<Light>();
		L13 = GameObject.Find ("LightplateM").GetComponent<Light>();
		L14 = GameObject.Find ("LightplateN").GetComponent<Light>();
		L15 = GameObject.Find ("LightplateO").GetComponent<Light>();
		L16 = GameObject.Find ("LightplateP").GetComponent<Light>();
		L17 = GameObject.Find ("LightplateQ").GetComponent<Light>();
		L18 = GameObject.Find ("LightplateR").GetComponent<Light>();
		L19 = GameObject.Find ("LightplateS").GetComponent<Light>();
		L20 = GameObject.Find ("LightplateT").GetComponent<Light>();
		L21 = GameObject.Find ("LightplateU").GetComponent<Light>();
		L22 = GameObject.Find ("LightplateV").GetComponent<Light>();
		L23 = GameObject.Find ("LightplateW").GetComponent<Light>();
		L24 = GameObject.Find ("LightplateX").GetComponent<Light>();
		L25 = GameObject.Find ("LightplateY").GetComponent<Light>();
	}

	void stopDoor()
	{
		DS.enabled = false;
		LS.enabled = false;
	}

	void Update()
	{
		checkOverlap (transform.position,sphereSize);

		if(L1.enabled == true && L2.enabled == true && L3.enabled == true && L4.enabled == true && L5.enabled == true && L6.enabled == false && L7.enabled == true && L8.enabled == false && L9.enabled == true && L10.enabled == false && L11.enabled == false && L12.enabled == false && L13.enabled == true && L14.enabled == false && L15.enabled == false && L16.enabled == false && L17.enabled == true && L18.enabled == false && L19.enabled == true && L20.enabled == false && L21.enabled == true && L22.enabled == true && L23.enabled == true && L24.enabled == true && L25.enabled == true)
		{
			DS.enabled = true;
			Invoke ("stopDoor", 2f);
		}
	}

	void checkOverlap(Vector3 center, float radius) 
	{
		Collider[] col = Physics.OverlapSphere(center,radius);
		int i = 0;

		while(i<col.Length) 
		{

			if(col[i].transform.name.Contains("LightplateA")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L1.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L1.enabled = false;
				}
			}

			if(col[i].transform.name.EndsWith("LightplateB")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L2.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L2.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateC")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L3.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L3.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateD")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L4.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L4.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateE")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L5.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L5.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateF")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L6.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L6.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateG")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L7.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L7.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateH")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L8.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L8.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateI")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L9.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L9.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateJ")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L10.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L10.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateK")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L11.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L11.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateL")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L12.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L12.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateM")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L13.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L13.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateN")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L14.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L14.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateO")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L15.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L15.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateP")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L16.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L16.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateQ")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L17.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L17.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateR")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L18.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L18.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateS")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L19.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L19.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateT")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L20.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L20.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateU")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L21.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L21.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateV")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L22.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L22.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateW")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L23.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L23.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateX")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L24.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L24.enabled = false;
				}
			}

			if(col[i].transform.name.Contains("LightplateY")) 
			{
				if (Input.GetKeyDown("q")) 
				{
					L25.enabled = true;
				}
				if (Input.GetKeyDown("e"))
				{
					L25.enabled = false;
				}
			}
			i++;
		}
	}

	void OnDrawGizmosSelected() 
	{
		Gizmos.color = new Color(0.5f,0f,0f,0.5f);
		Gizmos.DrawSphere(transform.position,sphereSize);
	}
}
