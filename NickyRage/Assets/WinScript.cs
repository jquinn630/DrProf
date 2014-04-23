using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "NickyRage")
		{
			GameObject.Find("HelpText").GetComponent<GUIText>().text = "This must be what they were looking for!\n  I'd better investigate more!";
			Time.timeScale=0;
		}
	}
}
