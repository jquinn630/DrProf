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
		int one = GameObject.Find("Room4Puzzle/Tile1").GetComponent<TileActive>().isTileOn;
		int two = GameObject.Find("Room4PuzzleTile2").GetComponent<TileActive>().isTileOn;
		int three = GameObject.Find("Room4PuzzleTile3").GetComponent<TileActive>().isTileOn;
		int four = GameObject.Find("Room4PuzzleTile4").GetComponent<TileActive>().isTileOn;
		int five = GameObject.Find("Room4PuzzleTile5").GetComponent<TileActive>().isTileOn;
		int six = GameObject.Find("Room4PuzzleTile6").GetComponent<TileActive>().isTileOn;
		
		
		if (one==1 && two==1 && three ==1 && four ==1 && five==1 && six==1 && !isSolved)
		{
			isSolved = true;
			GameObject.Find("Room4PuzzleTile1").renderer.material.color=Color.green;
			GameObject.Find("Room4PuzzleTile2").renderer.material.color=Color.green;
			GameObject.Find("Room4PuzzleTile3").renderer.material.color=Color.green;
			GameObject.Find("Room4PuzzleTile4").renderer.material.color=Color.green;
			GameObject.Find("Room4PuzzleTile5").renderer.material.color=Color.green;
			GameObject.Find("Room4PuzzleTile6").renderer.material.color=Color.green;
			
			GameObject.Find("Room2/DoorParent1/Door").GetComponent<BarrierLockedDoor>().barrierOne = false;
			GameObject.Find("Room2/DoorParent1/Barrier1").SetActive(false);
		}
		
	}
}
