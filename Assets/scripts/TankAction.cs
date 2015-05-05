using UnityEngine;
using System.Collections;

public class TankAction : MonoBehaviour {
	public float scrlSpd;
	public float lunchPosMin, lunchPosMax;
	public GameObject TBullet;
	float lunchPos;
	bool lunchChk;

	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("01_EnemyList").transform;
		transform.position = new Vector2(128.0f,5.1f);
		rigidbody2D.velocity = new Vector2(-scrlSpd,0);
		lunchPos = Random.Range(lunchPosMin,lunchPosMax);
	
	}
	
	void Update() {
		/*
			* X축 640~1280 사이에서 발사된다.
			* 발사 시점에서 플레이어가 있는 위치로 발사된다.
		*/
		
		//lunchPosMin 에서 lunchPosMax 사이에서 Angel을 조준하여 탄환발사
		if(lunchChk == false && transform.position.x <= lunchPos)
		{
			GameObject TBulletPos = (GameObject)Instantiate(TBullet);
			TBulletPos.SetActive(false);
			TBulletPos.transform.position = transform.position;
			TBulletPos.SetActive(true);
			lunchChk = true;
		}
	}
	
}
