using UnityEngine;
using System.Collections;

public class GameOverAction : MonoBehaviour {
	float ScrWidthRatio;
	float ScrHeightRatio;
	float tempScore;
	
	public float restartBtnPosX , restartBtnPosY, restartBtnHeight, restartBtnWidth;
	public float shareBtnPosX , shareBtnPosY, shareBtnHeight, shareBtnWidth;
	public float scoreBoxPosX, scoreBoxPosY;
	
	public Texture restartBtn, shareBtn;

	// Use this for initialization
	void Start () {
		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;
		
	}
	
	void OnEnable()
	{
		tempScore = GameStatus.chkPreScore();
		guiText.text = "Score : " + tempScore.ToString("#,##0") + "m";
		guiText.fontSize = (int)(guiText.fontSize * ScrHeightRatio);
		transform.position = new Vector2(scoreBoxPosX/127, scoreBoxPosY/72);
	}
	
	// Update is called once per frame
	//void Update () {
	//}
	
	void OnGUI()
	{
		if(GUI.Button (new Rect (restartBtnPosX*10 * ScrWidthRatio,
		                         (72.0f-restartBtnPosY-restartBtnHeight)*10 * ScrHeightRatio, 
		                         restartBtn.width * ScrWidthRatio, 
		                         restartBtn.height * ScrHeightRatio), 
		               restartBtn,GUIStyle.none)
					  )
		{
			restartGame();
		}
		
		if(GUI.Button (new Rect (shareBtnPosX*10 * ScrWidthRatio, 
		                         (72.0f-shareBtnPosY-shareBtnHeight)*10 * ScrHeightRatio, 
		                         shareBtn.width * ScrWidthRatio, 
		                         shareBtn.height * ScrHeightRatio), 
		               shareBtn,GUIStyle.none)
		   )
		{
			//sharecode
		}
	}
	
	void restartGame()
	{
		GameStatus.onGameStart();
		GameStatus.onGameOver();
		GameObject gameStartSetup = GameObject.Find("03_SystemUI");
		gameStartSetup.transform.FindChild("gameStartSet").gameObject.SetActive(true);
		gameObject.SetActive(false);
	}
}
