using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform follow;

	// Use this for initialization
	void Start () {
		follow = GameObject.Find ("NickyRage").transform;
		transform.position = follow.position;

		Transform camera = GameObject.Find ("Main Camera").transform;
		camera.position = new Vector3 (transform.position.x, transform.position.y + 10, transform.position.z + 10); 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = follow.position;
	}
}
