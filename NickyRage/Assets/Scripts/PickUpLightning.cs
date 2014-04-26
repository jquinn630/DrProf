using UnityEngine;
using System.Collections;

public class PickUpLightning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "NickyRage")
		{
			gameObject.SetActive(false);
			GameObject.Find("NickyRage").gameObject.GetComponent<ShootLightning>().hasLightning = true;	
		}
	}
}
