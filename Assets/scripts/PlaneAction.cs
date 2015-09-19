using UnityEngine;
using System.Collections;

public class PlaneAction : MonoBehaviour {
	public float scrlSpd, upDownSpd, upDownChkPoint, downLimit;
	public float posMin, posMax;
	float randPos;
	bool upDownChk;
	GameObject angel;
	
	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("01_EnemyList").transform;
		upDownChk = false;
		angel = GameObject.Find("Angel01");
		randPos = Random.Range(posMin, posMax); //randPos = Random.Range(5.1f, 46.0f);
		transform.position = new Vector2(128.0f,randPos);
		GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpd,0);
	}
	
	void Update () {
		/*
			*X축 640 지점에 도착했을 때, 플레이어 방향으로 상승, 하강한다.
			*Y축 200 지점 이하로는 하강하지 않는다.
			*하강중 Y축 200 지점 이하가 될 경우 하강을 멈추고 직진한다.
			*상승중 상단 벽에 접촉했을 경우 상승을 멈추고 직진한다.
			*상승속도 및 하강 속도 : 8
		*/
		
		//상승하강 패턴
		if(upDownChk == false && (transform.position.x <= upDownChkPoint))
		{			
			if(angel.transform.position.y > transform.position.y)
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpd, upDownSpd);
			}
			else
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpd, -upDownSpd);
			}
			upDownChk = true;
		}
		
		//상승하강 제한
		if(upDownChk == true && (transform.position.y <= downLimit || transform.position.y >= 59.0f))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpd,0);
		}
	}
}
