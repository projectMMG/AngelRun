using UnityEngine;
using System.Collections;

public class HelicopAction : MonoBehaviour {
	public float scrlSpd, upSpd, upChkPoint, upLimit;
	public GameObject missile;
	//public float posMin, posMax;
	float randPos;
	bool upChk, lunchChk;
	GameObject angel;

	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("01_EnemyList").transform;
		//randPos = Random.Range(posMin, posMax); //randPos = Random.Range(5.1f, 46.0f);
		transform.position = new Vector2(128.0f,5.1f);
		rigidbody2D.velocity = new Vector2(-scrlSpd,0);
		upChk = false;
		lunchChk = false;
		angel = GameObject.Find("Angel01");
	}
	
	void Update () {
		/*
			*바닥에 붙어서 나타난다.
			*위치가 1160이 됐을때 전진을 멈추고 상단 벽까지 상승한다.
			*플레이어와 일직선이 됐을때 미사일을 쏜다.
			*미사일을 쏘고 뒤로 돌아 퇴장한다.
		*/
		
		//upChkPoint 도달시 전진 멈추고 상승
		if(upChk == false && transform.position.x <= upChkPoint)
		{
			rigidbody2D.velocity = new Vector2(0, upSpd);
			upChk = true;
		}
		
		//upLimit 도달시 상승 멈추고 퇴장
		if(upChk == true && transform.position.y >= upLimit)
		{
			rigidbody2D.velocity = new Vector2(scrlSpd, 0);
		}
		
		//화면밖으로 나가면 제거
		if(upChk == true && transform.position.x >= 128.0f)
		{
			rigidbody2D.velocity = new Vector2(0, 0);
			transform.position = new Vector2(-10.0f,36.0f);
		}
		
		//Angel과 일직선이 되면 미사일 발사
		if(upChk == true && lunchChk == false
		&& angel.transform.position.y <= transform.position.y 
		&& angel.transform.position.y + 50 >= transform.position.y)
		{
			GameObject missilePos = (GameObject)Instantiate(missile);
			missilePos.SetActive(false);
			missilePos.transform.position = transform.position;
			missilePos.SetActive(true);
			lunchChk = true;
		}
	}
	
}
