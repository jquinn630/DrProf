using UnityEngine;
using System.Collections;

public class CubeLockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision other){
		rigidbody.constraints = rigidbody.constraints | RigidbodyConstraints.FreezePositionY;
		if (other.gameObject.name != "NickyRage")
		{
			rigidbody.constraints = rigidbody.constraints | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;		
		}
		else
		{
			rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
		}
	}
}
