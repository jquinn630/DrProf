using UnityEngine;
using System.Collections;
using System;

public class ShootLightning : MonoBehaviour {

	public bool hasLightning = false;

	int counter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0) && hasLightning) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			GameObject.Find("Target").transform.position = ray.origin + 50*ray.direction;
			GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.enabled = true;
			GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.Emit (GameObject.Find("hand.R").GetComponent<LightningBolt>().zigs);
			GameObject.Find("hand.R").GetComponent<LightningBolt>().particles = GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.particles;

//			GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.emit = true;
//			foreach (ParticleEmitter p in GetComponentsInChildren<ParticleEmitter>()) {
//				p.emit = true;
//			}
//			GameObject.Find("hand.R").GetComponent<LightningBolt>().particles =
//			            GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.particles;
//			counter = 50;
			Debug.Log ("START");
		}
		else {
//			counter--;
//			if(counter == 0) {
				GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.enabled = false;
//				GameObject.Find("hand.R").GetComponent<LightningBolt>().particleEmitter.emit = false;
//				foreach (ParticleEmitter p in GetComponentsInChildren<ParticleEmitter>()) {
//					p.emit = false;
//				}

				GameObject.Find("hand.R").GetComponent<LightningBolt>().particles = new Particle[0];
				Debug.Log("DONE");
//			}
		}
	}
}
