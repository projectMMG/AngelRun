using UnityEngine;
using System.Collections;

public class GameStartAction : MonoBehaviour {

    Texture TouchImg;
    float Alpa4Fade;
    float AlpaDir;
    float Time4Fade;
    float ScrWidthRatio;
    float ScrHeightRatio;


    void init()
    { 
        //입력대기 메세지(임시)
        this.TouchImg = Resources.Load("img/TouchImg") as Texture;

        //이미지 점멸 초기설정
        this.Alpa4Fade = 1.0f;
        this.AlpaDir = 0.1f;
        this.ScrWidthRatio = Screen.width / 1280.0f;
        this.ScrHeightRatio = Screen.height / 720.0f;

    }

    // Use this for initialization
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update () {
		
        //안드로이드 일 경우 터치인식 동작
		if(Application.platform == RuntimePlatform.Android)
		{
			int cnt = Input.touchCount;
			
			for(int i = 0;i<cnt;++i)
			{
				Touch touch = Input.GetTouch(i);
				
				if(touch.phase == TouchPhase.Began)
				{
                    gameStating();
				}
			}
		}
		
        //키보드 윗화살표 입력 시 동작
		if(Input.GetKey(KeyCode.UpArrow))
		{
            gameStating();
        }
		
	}

    void OnGUI()
    {
        //터치 이미지 점멸
        Time4Fade += Time.deltaTime;
        if (Time4Fade >= 0.1f)
        {
            if (Alpa4Fade <= 0)
            {
                AlpaDir = 0.05f;
            }
            else if (Alpa4Fade >= 1)
            {
                AlpaDir = -0.05f;
            }
            Alpa4Fade += AlpaDir;
            Time4Fade = 0;
        }
        
        GUI.color = new Color(0, 0, 0, Alpa4Fade);
        GUI.DrawTexture(new Rect(384 * ScrWidthRatio, 400 * ScrHeightRatio, this.TouchImg.width * ScrWidthRatio, this.TouchImg.height * ScrHeightRatio), this.TouchImg);
    }

    //입력확인 후 동작할 게임세팅
    void gameStating()
    {
        GameStatus.offGameOver();
        GameObject startCall = GameObject.Find("01_GameObj");
        startCall.transform.FindChild("Obstacle").gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
