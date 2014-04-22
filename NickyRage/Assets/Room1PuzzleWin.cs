using UnityEngine;
using System.Collections;

public class Room1PuzzleWin : MonoBehaviour {

	public GameObject Door;
	bool isSolved;
	
	// Use this for initialization
	void Start () {
		isSolved = false;
		Door = GameObject.Find("Room1/DoorParent1/Door");
	}
	
	// Update is called once per frame
	void Update () {
		int one = GameObject.Find("Tile6").GetComponent<TileActive>().isTileOn;
		int two = GameObject.Find("Tile7").GetComponent<TileActive>().isTileOn;
		int three = GameObject.Find("Tile8").GetComponent<TileActive>().isTileOn;
		int four = GameObject.Find("Tile9").GetComponent<TileActive>().isTileOn;
		
		if (one==1 && two==1 && three ==1 && four ==1 && !isSolved)
		{
			isSolved = true;
			foreach (AnimationState clip in Door.animation)
			{
				Door.animation.Play(clip.name);
			}
			GameObject.Find("Tile6").renderer.material.color=Color.green;
			GameObject.Find("Tile7").renderer.material.color=Color.green;
			GameObject.Find("Tile8").renderer.material.color=Color.green;
			GameObject.Find("Tile9").renderer.material.color=Color.green;
			
		}
		
	}
}
