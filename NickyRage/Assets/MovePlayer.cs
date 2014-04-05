using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Animator animControl;
	static int jumpState = Animator.StringToHash("Base.Jump"); 
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool up = Input.GetKey (KeyCode.W);
		bool down = Input.GetKey (KeyCode.S);
		bool left = Input.GetKey (KeyCode.A);
		bool right = Input.GetKey (KeyCode.D);
		bool space = Input.GetKey (KeyCode.Space);

		AnimatorStateInfo currentBaseState = animControl.GetCurrentAnimatorStateInfo(0);

		if (up) {
			animControl.Play("WalkingForward");
		}
		else if (down) {
			animControl.Play("WalkingBackward");
		}
		else if (space){
			animControl.Play("Jump");
		}
		else if (currentBaseState.nameHash != jumpState){
			animControl.Play("Idle");
		}

		Debug.Log(animControl.GetCurrentAnimatorStateInfo(0));
	}
}
