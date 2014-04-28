using UnityEngine;
using System.Collections;
using System;

public class ShootLightning : MonoBehaviour {

	public bool hasLightning = false;
	
	int counter = 60;
	public bool shooting = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		shooting = false;
		if (Input.GetMouseButton (0) && hasLightning && counter > 0) {
			shooting = true;
			counter--;
			if(counter == 0) {
				shooting = false;
				counter = 60;
			}

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit myhit;

			if (Physics.Raycast(ray, out myhit, 50.0f)) {
				GameObject.Find("Target").transform.position = ray.origin + myhit.distance*ray.direction;

				if(myhit.collider == GameObject.Find("LightningTarget").collider) {
					GameObject.Find("Door6").animation.Play("Door6Up");
					GameObject.Find("LightningTarget").renderer.material.color = Color.cyan;
				}
				if(myhit.collider == GameObject.Find("ElevatorSwitch").collider) {
					GameObject.Find("ElevatorSwitch").GetComponent<ElevatorSwitchScript>().activated = true;
					GameObject.Find("ElevatorSwitch").renderer.material.color = Color.cyan;
				}

			}
			else GameObject.Find("Target").transform.position = ray.origin + 50*ray.direction;
			GameObject.Find("hand.L").GetComponent<LightningBolt>().particleEmitter.enabled = true;
			GameObject.Find("hand.L").GetComponent<LightningBolt>().particleEmitter.Emit (GameObject.Find("hand.L").GetComponent<LightningBolt>().zigs);
			GameObject.Find("hand.L").GetComponent<LightningBolt>().particles = GameObject.Find("hand.L").GetComponent<LightningBolt>().particleEmitter.particles;

//			GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.emit = true;
//			foreach (ParticleEmitter p in GetComponentsInChildren<ParticleEmitter>()) {
//				p.emit = true;
//			}
//			GameObject.Find("hand.R").GetComponent<LightningBolt>().particles =
//			            GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.particles;
//			counter = 50;
		}
		else {
//			counter--;
//			if(counter == 0) {
				GameObject.Find("hand.L").GetComponent<LightningBolt>().particleEmitter.enabled = false;
//				GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.emit = false;
//				foreach (ParticleEmitter p in GetComponentsInChildren<ParticleEmitter>()) {
//					p.emit = false;
//				}

				GameObject.Find("hand.L").GetComponent<LightningBolt>().particles = new Particle[0];
//			}
		}
	}
}
