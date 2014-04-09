using UnityEngine;
using System.Collections;

public class PickUpKey : MonoBehaviour {

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
			other.gameObject.GetComponent<MovePlayer>().NumKeys++;	
		}
	}
}
