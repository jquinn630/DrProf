using UnityEngine;
using System.Collections;

public class ElevatorScript : MonoBehaviour {

	public GameObject myswitch;
	public bool moving = false;

	// Use this for initialization
	void Start () {

	}
	
	void OnCollisionEnter (Collision other) {
		if(myswitch.GetComponent<ElevatorSwitchScript>().activated && other.transform.name == "NickyRage" && !moving) {
			moving = true;
		}
	}

	void Update() {
		if(moving) {
			GameObject.Find ("Elevator").transform.Translate(0.0f, .5f, 0.0f);
			if(GameObject.Find ("Elevator").transform.position.y >= 30) {
				moving = false;
			}
		}
	}

//	void OnCollisionExit(Collision other) {
//		if(myswitch.GetComponent<ElevatorSwitchScript>().activated && other.transform.name == "NickyRage") {
//			GameObject.Find("Elevator").animation.Play("ElevatorDown");
//		}
//	}
}
