using UnityEngine;
using System.Collections;

public class CamRotate : MonoBehaviour {
	
	// Update is called once per frame
	public GameObject target;
	public GameObject parent;
	public Vector2 playerVelocity;
	public Vector2 cameraVector;
	public float angle = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
	
	}
	
	void LateUpdate () {
			Vector3 targetDirection = target.GetComponent<MovePlayer>().moveDirection;
	
			playerVelocity = new Vector2 (-targetDirection.x, -targetDirection.z);
			playerVelocity.Normalize ();
			cameraVector = new Vector2 (parent.transform.position.x - transform.position.x, parent.transform.position.z - transform.position.z);
			cameraVector.Normalize ();
			
			angle = Vector2.Angle (cameraVector, playerVelocity);
			Vector3 cross = Vector3.Cross(cameraVector, playerVelocity);
				
			if (cross.z > 0){
				angle *= -1;
			}
			
				transform.RotateAround (parent.transform.position, Vector3.up, angle * Time.deltaTime);

					
		//transform.LookAt (parent.transform);
	}
	
}
