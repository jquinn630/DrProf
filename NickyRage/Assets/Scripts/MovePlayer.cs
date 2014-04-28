using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Animator animControl;
	static int jumpState = Animator.StringToHash("Base.Jump"); 
	public int NumKeys;
	int jumptimer = 0;
	public GUIText keyText;
	public GameObject hammerObject;

	//movement stuffs
	float moveMagConst;
	public Vector3 moveDirection;
	float rotDeg;
	public float runMultiplier;

	// powerup
	public bool hasHammer = false;
	public bool hammerTime;
	public bool hammerStart;
	int hammerTimer;

	int runcooldown = 200;
	int runlimit = 80;

	// Use this for initialization
	void Start () {
		moveMagConst= 16f;
		moveDirection = new Vector3 (0f, 0f, 1f);
		rotDeg = 120f;
		NumKeys = 0;
		hammerTime = false;
		hammerStart= false;
		Physics.gravity = new Vector3(0.0f, -20.0f, 0.0f);
	}
	
	void Update()
	{
		keyText.text = "Keys: " + NumKeys;
		if(hammerStart)
		{
			hammerTimer++;	
		}
		if(hammerTimer>=35)
		{
			hammerTime=true;
		}
		if (hammerTimer>105)
		{
			hammerTimer=0;
			hammerTime=false;
			hammerStart=false;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject nicky = GameObject.Find ("NickyRage");

		bool up = Input.GetKey (KeyCode.W);
		bool down = Input.GetKey (KeyCode.S);
		bool left = Input.GetKey (KeyCode.A);
		bool right = Input.GetKey (KeyCode.D);
		bool space = Input.GetKey (KeyCode.Space);
		bool hammer = Input.GetKey (KeyCode.E);
		bool leftmouse = Input.GetMouseButtonDown (0); // left click
		bool shift = Input.GetKey (KeyCode.LeftShift);

		AnimatorStateInfo currentBaseState = animControl.GetCurrentAnimatorStateInfo(0);
		float moveMagnitude = moveMagConst * Time.deltaTime;

		if(runlimit == 0) {
			runcooldown--;
			if(runcooldown == 0) {
				runlimit = 80;
			}
		}

		if (up && currentBaseState.nameHash != jumpState) {
			if(shift && runlimit > 0) {
				transform.position -= new Vector3(moveDirection.x * moveMagnitude * runMultiplier, 0f, moveDirection.z * moveMagnitude * runMultiplier);
				animControl.Play("RunningForward");
				runlimit--;
				runcooldown = 200;
			}
			else {
				transform.position -= new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
				animControl.Play("WalkingForward");
			}
		}
		else if (up && currentBaseState.nameHash == jumpState && !hammerStart)
		{
			transform.position -= new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
		}
		else if (down  && currentBaseState.nameHash != jumpState && !hammerStart) {
			transform.position += new Vector3(moveDirection.x * moveMagnitude, 0f, moveDirection.z * moveMagnitude);
			animControl.Play("WalkingBackward");
		}
		else if (currentBaseState.nameHash != jumpState && !hammerStart){
			animControl.Play("Idle");
		}

		if (space && currentBaseState.nameHash != jumpState && !hammerStart){
			animControl.Play("Jump");
			jumptimer = 0;
		}
		
		if (left  && currentBaseState.nameHash != jumpState && !hammerStart) {
			moveDirection = Quaternion.Euler(0, -rotDeg * Time.deltaTime, 0) * moveDirection; 
			transform.RotateAround(transform.position, Vector3.up, -rotDeg*Time.deltaTime);
			moveDirection.Normalize();
		}
		if (right  && currentBaseState.nameHash != jumpState && !hammerStart) {
			moveDirection = Quaternion.Euler (0, rotDeg * Time.deltaTime, 0) * moveDirection; 
			transform.RotateAround (transform.position, Vector3.up, rotDeg * Time.deltaTime);
			moveDirection.Normalize();
		}
		if(currentBaseState.nameHash == jumpState && !hammerStart) {
			jumptimer++;
			if(jumptimer == 16) {
				nicky.rigidbody.AddForce(new Vector3(0.0f, 16.2f, 0.0f), ForceMode.Impulse);
			}
		} // times the jump with the animation
		if (hammer && hasHammer && !hammerStart) {
			//foreach (AnimationState clip in hammerObject.animation)
			//{
			//	hammerObject.animation.Play(clip.name);
			//}
			animControl.Play("SwingHammer");
			hammerStart=true;
			hammerTimer=0;
		}

//		Debug.Log(animControl.GetCurrentAnimatorStateInfo(0));
//		Debug.Log (nicky.rigidbody.velocity);
	}

	
}
