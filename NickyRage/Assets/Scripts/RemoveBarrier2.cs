using UnityEngine;
using System.Collections;

public class RemoveBarrier2 : MonoBehaviour {

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
			gameObject.renderer.material.color = Color.green;
			GameObject.Find("Room2/DoorParent1/Door").GetComponent<BarrierLockedDoor>().barrierTwo = false;
			GameObject.Find("Room2/DoorParent1/Barrier2").SetActive(false);
		}
	}
}
