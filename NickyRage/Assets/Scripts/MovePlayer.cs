﻿using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Animator animControl;
	static int jumpState = Animator.StringToHash("Base.Jump"); 
	public int NumKeys;
	int jumptimer = 0;
	public GUIText keyText;

	//movement stuffs
	float moveMagConst;
	public Vector3 moveDirection;
	float rotDeg;

	// Use this for initialization
	void Start () {
		moveMagConst= 12f;
		moveDirection = new Vector3 (0f, 0f, 1f);
		rotDeg = 120f;
		NumKeys = 0;
	}
	
	void Update()
	{
		keyText.text = "Keys: " + NumKeys;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject nicky = GameObject.Find ("NickyRage");

		bool up = Input.GetKey (KeyCode.W);
		bool down = Input.GetKey (KeyCode.S);
		bool left = Input.GetKey (KeyCode.A);
		bool right = Input.GetKey (KeyCode.D);
		bool space = Input.GetKey (KeyCode.Space);

		AnimatorStateInfo currentBaseState = animControl.GetCurrentAnimatorStateInfo(0);
		float moveMagnitude = moveMagConst * Time.deltaTime;

		if (up && currentBaseState.nameHash != jumpState) {
			transform.position -= new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
			animControl.Play("WalkingForward");
		}
		else if (up && currentBaseState.nameHash == jumpState)
		{
			transform.position -= new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
		}
		else if (down) {
			transform.position += new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
			animControl.Play("WalkingBackward");
		}
		else if (space && currentBaseState.nameHash != jumpState){
			animControl.Play("Jump");
			jumptimer = 0;
		}
		else if (currentBaseState.nameHash != jumpState){
			animControl.Play("Idle");
		}
		
		if (left  && currentBaseState.nameHash != jumpState) {
			moveDirection = Quaternion.Euler(0, -rotDeg * Time.deltaTime, 0) * moveDirection; 
			transform.RotateAround(transform.position, Vector3.up, -rotDeg*Time.deltaTime);
			moveDirection.Normalize();
		}
		if (right  && currentBaseState.nameHash != jumpState) {
			moveDirection = Quaternion.Euler (0, rotDeg * Time.deltaTime, 0) * moveDirection; 
			transform.RotateAround (transform.position, Vector3.up, rotDeg * Time.deltaTime);
			moveDirection.Normalize();
		}
		if(currentBaseState.nameHash == jumpState) {
			jumptimer++;
			if(jumptimer == 16) {
				nicky.rigidbody.AddForce(new Vector3(0.0f, 15.0f, 0.0f), ForceMode.Impulse);
			}
		} // times the jump with the animation


//		Debug.Log(animControl.GetCurrentAnimatorStateInfo(0));
//		Debug.Log (nicky.rigidbody.velocity);
	}
}
