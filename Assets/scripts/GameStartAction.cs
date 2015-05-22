﻿using UnityEngine;
using System.Collections;

public class GameStartAction : MonoBehaviour {
	public float titleboxX, titleboxY;

	void init()
	{
		titleboxPosSet();
	}
	
	
	// Use this for initialization
	void Start () {
		init ();
	}
	
	// Update is called once per frame
	void Update () {
		int cnt = Input.touchCount;
		
		for(int i = 0;i<cnt;++i)
		{
			Touch touch = Input.GetTouch(i);
			
			if(touch.phase == TouchPhase.Ended)
			//if(Input.GetKey(KeyCode.UpArrow))
			{
				GameStatus.offGameOver();
				GameObject startCall = GameObject.Find("01_GameObj");
				startCall.transform.FindChild("Obstacle").gameObject.SetActive(true);
				this.gameObject.SetActive(false);
			}
		}
		
	}
	
	void titleboxPosSet()
	{
		transform.position = new Vector2(titleboxX/127, titleboxY/72);
	}
}
