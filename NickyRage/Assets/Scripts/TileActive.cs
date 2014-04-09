using UnityEngine;
using System.Collections;

public class TileActive : MonoBehaviour {

	public int isTileOn;

	// Use this for initialization
	void Start () {
		isTileOn=0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name != "NickyRage" && isTileOn==0)
		{
			isTileOn = 1;
			other.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y+5, transform.position.z);
		}
	}
	
	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.name != "NickyRage")
		{
			isTileOn = 0;

		}
	}
}
