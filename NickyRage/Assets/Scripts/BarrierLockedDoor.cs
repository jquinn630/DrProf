using UnityEngine;
using System.Collections;

public class BarrierLockedDoor : MonoBehaviour {

	public bool barrierOne;
	public bool barrierTwo;
	public bool barrierThree;
	public GUIText helpText;

	// Use this for initialization
	void Start () {
		barrierOne=true;
		barrierTwo=true;
		barrierThree=true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "NickyRage")
		{
			if (!barrierOne&&!barrierTwo&&!barrierThree)
			{
				foreach (AnimationState clip in animation)
				{
					animation.Play(clip.name);
				}
			}
			else 
			{
				helpText = GameObject.Find("HelpText").GetComponent<GUIText>();
				helpText.text = "You must find a way to remove the barriers!.";
			}
		}
	}
}
