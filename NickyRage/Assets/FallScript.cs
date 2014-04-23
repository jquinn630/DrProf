using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "NickyRage")
		{
			other.transform.position = GameObject.Find("Platforms/Platform1").GetComponent<Transform>().position;
			other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y+2, other.transform.position.z);
			GameObject.Find ("Platform2/HammerSwitch").GetComponent<HammerSwitchScript>().ResetPosition();
			GameObject.Find ("Platform2.5/HammerSwitch").GetComponent<HammerSwitchScript>().ResetPosition();
			GameObject.Find ("Platform3/HammerSwitch").GetComponent<HammerSwitchScript>().ResetPosition();
			GameObject.Find ("Platform4/HammerSwitch").GetComponent<HammerSwitchScript>().ResetPosition();
		}
	}
}
