﻿using UnityEngine;
using System.Collections;

public class Room3PuzzleWin : MonoBehaviour {

	public int isSolved;
	public GameObject theKey;

	// Use this for initialization
	void Start () {
		isSolved = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (isSolved == 0) {
		
			int one = GameObject.Find("Room1BlockPuzzle/Tile6").GetComponent<TileActive>().isTileOn;
			int two = GameObject.Find("Room1BlockPuzzle/Tile7").GetComponent<TileActive>().isTileOn;
			int three = GameObject.Find("Room1BlockPuzzle/Tile8").GetComponent<TileActive>().isTileOn;
			int four = GameObject.Find("Room1BlockPuzzle/Tile9").GetComponent<TileActive>().isTileOn;
			
			if (one==1 && two==1 && three ==1 && four ==1)
			{
				theKey.SetActive(true);
				isSolved = 1;
			}
		}
	}
}
