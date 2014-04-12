using UnityEngine;
using System.Collections;

public class PressSwitch : MonoBehaviour {
	// Use this for initialization
	bool ispressed = false;

	public GameObject mydoor;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision other) {
		if(!ispressed) {
			if (other.gameObject.name == "NickyRage") {
				animation["Switch1Down"].speed = 2.0f;
				animation.Play("Switch1Down");

				ispressed = true;
				foreach (AnimationState clip in mydoor.animation)
				{
					mydoor.animation.Play(clip.name);
				}
			}
		}
	}
}
