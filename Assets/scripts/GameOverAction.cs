using UnityEngine;
using System.Collections;

public class GameOverAction : MonoBehaviour {
	float ScrWidthRatio;
	float ScrHeightRatio;
	
	public float btnPosX , btnPosY, btnHeight, btnWidth;
	

	// Use this for initialization
	void Start () {
		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI()
	{
		if(GUI.Button (new Rect (btnPosX*10 * ScrWidthRatio, 
		                         (72.0f-btnPosY)*10 * ScrHeightRatio, 
								 btnWidth*10 * ScrWidthRatio, 
								 btnHeight*10 * ScrHeightRatio), 
								 "Restart")
					  )
		{
			restartGame();
		}
	}
	
	void restartGame()
	{
		GameStatus.onGameStart();
		GameObject gameStartSetup = GameObject.Find("03_SystemUI");
		gameStartSetup.transform.FindChild("gameStartSet").gameObject.SetActive(true);
		gameObject.SetActive(false);
	}
}
