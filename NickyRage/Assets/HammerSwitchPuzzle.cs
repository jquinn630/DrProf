using UnityEngine;
using System.Collections;

public class HammerSwitchPuzzle : MonoBehaviour {

	public GameObject switch1;
	public GameObject switch2;
	public GameObject switch3;
	public GameObject switch4;
	public GameObject switch5;
	int GameState;

	// Use this for initialization
	void Start () {
		switch1 = GameObject.Find("SwitchParent1/HammerSwitch");
		switch2 = GameObject.Find("SwitchParent2/HammerSwitch");
		switch3 = GameObject.Find("SwitchParent3/HammerSwitch");
		switch4 = GameObject.Find("SwitchParent4/HammerSwitch");
		switch5 = GameObject.Find("SwitchParent5/HammerSwitch");
		GameState = 0;
	}
	
	// Update is called once per frame
	void Update () {
		bool one = switch1.GetComponent<HammerSwitchScript>().isActive;
		bool two = switch2.GetComponent<HammerSwitchScript>().isActive;
		bool three = switch3.GetComponent<HammerSwitchScript>().isActive;
		bool four = switch4.GetComponent<HammerSwitchScript>().isActive;
		bool five = switch5.GetComponent<HammerSwitchScript>().isActive;
		if (GameState == 0)
		{
			if (one&&!two&&!three&&!four&&!five) GameState = 1;
			else GameState = 0;
			//ResetAll(one,two,three,four,five);
		}
		else if (GameState == 1)
		{
			if (one&&two&&!three&&!four&&!five) GameState = 2;
			else if (one&&!two&&!three&&!four&&!five) GameState =1;
			else {
				GameState = 0;
				ResetAll(one,two,three,four,five);
			}		
		}
		else if (GameState == 2)
		{
			if (one&&two&&three&&!four&&!five) GameState = 3;
			else if (one&&two&&!three&&!four&&!five) GameState =2;
			else {
				GameState = 0;
				ResetAll(one,two,three,four,five);
			}		}
		else if (GameState == 3)
		{
			if (one&&two&&three&&four&&!five) GameState = 4;
			else if (one&&two&&three&&!four&&!five) GameState =3;
			else {
				GameState = 0;
				ResetAll(one,two,three,four,five);
			}		}
		else if (GameState == 4)
		{
			if (one&&two&&three&&four&&five) GameState = 5;
			else if (one&&two&&three&&four&&!five) GameState =4;
			else {
				GameState = 0;
				ResetAll(one,two,three,four,five);
			}
		}
		else if (GameState == 5)
		{
			GameState = 6;
			switch1.gameObject.renderer.material.color = Color.green;
			switch2.gameObject.renderer.material.color = Color.green;
			switch3.gameObject.renderer.material.color = Color.green;
			switch4.gameObject.renderer.material.color = Color.green;
			switch5.gameObject.renderer.material.color = Color.green;
			GameObject.Find("WallJumpStructure/Second").GetComponent<Animation>().Play();
			GameObject.Find("WallJumpStructure/Third").GetComponent<Animation>().Play();
			GameObject.Find("WallJumpStructure/Fourth").GetComponent<Animation>().Play();
			GameObject.Find("WallJumpStructure/Fifth").GetComponent<Animation>().Play();
			GameObject.Find("WallJumpStructure/Six").GetComponent<Animation>().Play();
		}
	}
	
	void ResetAll(bool a, bool b, bool c, bool d, bool e){
			switch1.GetComponent<Animation>().Stop();
			switch2.GetComponent<Animation>().Stop();
			switch3.GetComponent<Animation>().Stop();
			switch4.GetComponent<Animation>().Stop();
			switch5.GetComponent<Animation>().Stop();
		
			if (a) switch1.GetComponent<HammerSwitchScript>().ResetPosition();
			if (b) switch2.GetComponent<HammerSwitchScript>().ResetPosition();
			if (c) switch3.GetComponent<HammerSwitchScript>().ResetPosition();
			if (d) switch4.GetComponent<HammerSwitchScript>().ResetPosition();
			if (e) switch5.GetComponent<HammerSwitchScript>().ResetPosition();
	}
}
