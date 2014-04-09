using UnityEngine;
using System.Collections;

public class DoorOpenLocked : MonoBehaviour {

	public GameObject nicky;
	public GUIText helpText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "NickyRage") {
				
			int numKeys = nicky.GetComponent<MovePlayer>().NumKeys;
				
			if (numKeys > 0)
			{
				nicky.GetComponent<MovePlayer>().NumKeys--;
				foreach (AnimationState clip in animation)
				{
					animation.Play(clip.name);
				}
			}
			else 
			{
				helpText = GameObject.Find("HelpText").GetComponent<GUIText>();
				helpText.text = "Door is locked.  You need a key.";
			}
		}
	}
	
	void OnCollisionExit (Collision other)
	{
		helpText = GameObject.Find("HelpText").GetComponent<GUIText>();
		helpText.text = "";
	}
	
	
}
