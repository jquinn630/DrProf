using UnityEngine;
using System.Collections;

public class ShootLightning : MonoBehaviour {

	public bool hasLightning = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool leftmouse = Input.GetMouseButton (0); // left click

		if (leftmouse && hasLightning) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			GameObject.Find("Target").transform.position = ray.origin + 50*ray.direction;
			GameObject.Find("hand.R").GetComponent<LightningBolt>().isShooting = true;
		}
		else {
			GameObject.Find("hand.R").GetComponent<LightningBolt>().isShooting = false;
		}
	}
}
