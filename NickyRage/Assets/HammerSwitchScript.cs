﻿using UnityEngine;
using System.Collections;

public class HammerSwitchScript : MonoBehaviour {

	public GameObject targetObj;
	public GameObject weapon;
	bool isActive;

	// Use this for initialization
	void Start () {
		isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		bool hammerTime = GameObject.Find("NickyRage").GetComponent<MovePlayer>().hammerTime;
		if (other.gameObject.name == weapon.name  && !isActive && hammerTime)
		{
			isActive = true;
			foreach (AnimationState clip in targetObj.animation)
			{
				targetObj.animation.Play(clip.name);
			}
			foreach (AnimationState clip in animation)
			{
				animation.Play(clip.name);
			}
			
			gameObject.renderer.material.color = Color.red;
		}
	}
}
