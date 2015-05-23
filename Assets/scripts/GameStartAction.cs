using UnityEngine;
using System.Collections;

public class GameStartAction : MonoBehaviour {

	void init()
	{
		
	}
	
	
	// Use this for initialization
	void Start () {
		init ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Application.platform == RuntimePlatform.Android)
		{
			int cnt = Input.touchCount;
			
			for(int i = 0;i<cnt;++i)
			{
				Touch touch = Input.GetTouch(i);
				
				if(touch.phase == TouchPhase.Began)
				{
					GameStatus.offGameOver();
					GameObject startCall = GameObject.Find("01_GameObj");
					startCall.transform.FindChild("Obstacle").gameObject.SetActive(true);
					this.gameObject.SetActive(false);
				}
			}
		}
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			GameStatus.offGameOver();
			GameObject startCall = GameObject.Find("01_GameObj");
			startCall.transform.FindChild("Obstacle").gameObject.SetActive(true);
			this.gameObject.SetActive(false);
		}
		
	}
}
