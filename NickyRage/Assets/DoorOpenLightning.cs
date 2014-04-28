using UnityEngine;
using System.Collections;

public class DoorOpenLightning : MonoBehaviour {
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
			helpText = GameObject.Find("HelpText").GetComponent<GUIText>();
			helpText.text = "Door is deactivated. Must reactivate!";
		}
	}
}
