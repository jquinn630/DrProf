using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {

	GameObject one;
	GameObject two;
	GameObject three;
	GameObject four;

	// Use this for initialization
	void Start () {
		one = GameObject.Find("Platform2/HammerSwitch");
		two = GameObject.Find("Platform2.5/HammerSwitch");
		three = GameObject.Find("Platform3/HammerSwitch");
		four = GameObject.Find("Platform4/HammerSwitch");
	}
	
	// Update is called once per frame
	void Update () {
		bool a = one.GetComponent<HammerSwitchScript>().isActive;
		bool b = two.GetComponent<HammerSwitchScript>().isActive;
		bool c = three.GetComponent<HammerSwitchScript>().isActive;
		bool d = four.GetComponent<HammerSwitchScript>().isActive;
		
		if (a && b && c && d)
		{
			one.renderer.material.color = Color.green;
			two.renderer.material.color = Color.green;
			three.renderer.material.color = Color.green;
			four.renderer.material.color = Color.green;
			
			GameObject.Find("Room2/DoorParent1/Door").GetComponent<BarrierLockedDoor>().barrierThree = false;
			GameObject.Find("Room2/DoorParent1/Barrier3").SetActive(false);
		}
	}
}
