using UnityEngine;
using System.Collections;

public class GameStartAction : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			GameStatus.offGameOver();
			GameObject startCall = GameObject.Find("01_GameObj");
			startCall.transform.FindChild("Obstacle").gameObject.SetActive(true);
			this.gameObject.SetActive(false);
		}
		
	}
}
