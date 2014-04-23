using UnityEngine;
using System.Collections;

public class Room4PuzzleScript : MonoBehaviour {

	bool isSolved;
	
	// Use this for initialization
	void Start () {
		isSolved = false;
	}
	
	// Update is called once per frame
	void Update () {
		int one = GameObject.Find("Tile1").GetComponent<TileActive>().isTileOn;
		int two = GameObject.Find("Tile2").GetComponent<TileActive>().isTileOn;
		int three = GameObject.Find("Tile3").GetComponent<TileActive>().isTileOn;
		int four = GameObject.Find("Tile4").GetComponent<TileActive>().isTileOn;
		int five = GameObject.Find("Tile5").GetComponent<TileActive>().isTileOn;
		int six = GameObject.Find("Tile6").GetComponent<TileActive>().isTileOn;
		
		
		if (one==1 && two==1 && three ==1 && four ==1 && five==1 && six==1 && !isSolved)
		{
			isSolved = true;
			GameObject.Find("Tile1").renderer.material.color=Color.green;
			GameObject.Find("Tile2").renderer.material.color=Color.green;
			GameObject.Find("Tile3").renderer.material.color=Color.green;
			GameObject.Find("Tile4").renderer.material.color=Color.green;
			GameObject.Find("Tile5").renderer.material.color=Color.green;
			GameObject.Find("Tile6").renderer.material.color=Color.green;
			
			GameObject.Find("Room2/DoorParent1/Door").GetComponent<BarrierLockedDoor>().barrierOne = false;
			GameObject.Find("Room2/DoorParent1/Barrier1").SetActive(false);
		}
		
	}
}
