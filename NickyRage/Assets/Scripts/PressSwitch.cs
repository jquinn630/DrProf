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
				foreach (AnimationState clip in animation){
					animation.Play(clip.name);
				}
				ispressed = true;
				foreach (AnimationState clip in mydoor.animation)
				{
					mydoor.animation.Play(clip.name);
				}
			}
		}
	}
}
