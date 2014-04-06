using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Animator animControl;
	static int jumpState = Animator.StringToHash("Base.Jump"); 
	int jumptimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject nicky = GameObject.Find ("NickyRage");

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
		else if (space && currentBaseState.nameHash != jumpState){
			animControl.Play("Jump");
			jumptimer = 0;
		}
		else if(currentBaseState.nameHash == jumpState) {
			jumptimer++;
			if(jumptimer == 16) {
				nicky.rigidbody.AddForce(new Vector3(0.0f, 15.0f, 0.0f), ForceMode.Impulse);
			}
		} // times the jump with the animation
		else if (currentBaseState.nameHash != jumpState){
			animControl.Play("Idle");
		}

//		Debug.Log(animControl.GetCurrentAnimatorStateInfo(0));
//		Debug.Log (nicky.rigidbody.velocity);
	}
}
