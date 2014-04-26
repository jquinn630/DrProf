using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform follow;
	public Transform cam;

	// Use this for initialization
	void Start () {
		follow = GameObject.Find ("NickyRage").transform;
		transform.position = follow.position;

		cam = GameObject.Find ("Main Camera").transform;
		cam.position = new Vector3 (transform.position.x, transform.position.y + 10, transform.position.z + 10); 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = follow.position;
	}
	
	void LateUpdate () {
//		if(Input.GetAxis("Mouse X")<0 ){
//			cam.RotateAround(cam.position, Vector3.up, -90*Time.deltaTime);
//		}
//		if(Input.GetAxis("Mouse X")>0 ){
//			cam.RotateAround(cam.position, Vector3.up, 90*Time.deltaTime);
//		}
	}
	
}
