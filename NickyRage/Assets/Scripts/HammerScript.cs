using UnityEngine;
using System.Collections;

public class HammerScript : MonoBehaviour {

	private bool isActive;
	private int textCt = 0;
	public Transform Hand;
	public GameObject UserHammer;

	// Use this for initialization
	void Start () {
		isActive = true;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (isActive && other.gameObject.name == "NickyRage")
		{
			isActive = false;
			(gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			UserHammer.SetActive(true);
			gameObject.SetActive(false);
			/*gameObject.transform.parent = Hand;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.RotateAround(gameObject.transform.position, Hand.right, 90);
			gameObject.transform.RotateAround(gameObject.transform.position, Hand.forward, -50);
			gameObject.transform.RotateAround(gameObject.transform.position, Hand.up, -30); */
			
		}
	}
}
