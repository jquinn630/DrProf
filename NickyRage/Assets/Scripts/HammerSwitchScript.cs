using UnityEngine;
using System.Collections;

public class HammerSwitchScript : MonoBehaviour {

	public GameObject targetObj;
	public GameObject weapon;
	Color currentColor;
	public bool isActive;

	// Use this for initialization
	void Start () {
		isActive = false;
		currentColor = gameObject.renderer.material.color;
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
	
	public void ResetPosition()
	{
		if (isActive)
		{
			isActive=false;
			gameObject.renderer.material.color = currentColor;
			gameObject.transform.localPosition = new Vector3(0, 0, 0);
		}
	}
}
