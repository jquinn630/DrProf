using UnityEngine;
using System.Collections;

public class DoorOpenUnlocked : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "NickyRage") {
			foreach (AnimationState clip in animation)
			{
				animation.Play(clip.name);
			}
		}
	}
}
