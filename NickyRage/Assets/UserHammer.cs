using UnityEngine;
using System.Collections;

public class UserHammer : MonoBehaviour {

	public GUIText helpText;
	public int helpcount;
	public bool isActive;

	// Use this for initialization
	void Start () {
		helpText = GameObject.Find("HelpText").GetComponent<GUIText>();
		helpText.text = "You have acquired the mighty hammer of Thor!";
		helpcount = 0;
		isActive = true;
		GameObject.Find("NickyRage").GetComponent<MovePlayer>().hasHammer = true; 
	}
	
	// Update is called once per frame
	void Update () {
		if (helpcount < 120 && isActive)
		{
			helpcount++;
		}
		if (helpcount >= 120 && isActive)
		{
			helpText.text = "";
			isActive = false;
		}
	}
}
