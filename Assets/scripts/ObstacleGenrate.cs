using UnityEngine;
using System.Collections;

public class ObstacleGenrate : MonoBehaviour {
	//***************************
	//빌딩 프리팹 0-빌딩 1-집 2-구름
	//***************************
	public GameObject[] ObstacleBuilding = new GameObject[2];
	
	//*********************************
	//적 프리팹 0-헬리콥터 1-비행기 2-탱크
	//*********************************
	public GameObject[] ObstacleEnemy = new GameObject[3];
	
	public float genTimeBuilding, startTimeBuilding, regenMaxDelayBuilding, regenMinDelayBuilding, regenMaxDelayEnemy, regenMinDelayEnemy;
	
	//float delayTemp = 0;
	int genBuildingType, genEnemyType;
	
	// Use this for initialization
	void Start () {
		//반복 실행
		InvokeRepeating("fGenBuilding",startTimeBuilding,genTimeBuilding);
		
		//적 랜덤생성
		fGenEnemy();
	}
		
	//충돌 시 동작
	void OnTriggerEnter2D(Collider2D Obstacle){
	
		if(Obstacle.transform.name == "Angel01")
		{
			Time.timeScale = 0;
		}
		else
		{
			//건물 장애물들의 재생성
			if(Obstacle.transform.parent.name == "00_Cloud" || 
			   Obstacle.transform.parent.name == "02_BuildingList")
			{
				StartCoroutine(fRegenBuilding());
				if(Obstacle.transform.parent.name == "00_Cloud")
				{
					GameStatus.minusCloudCnt();
				}
				else
				{
					GameStatus.minusBuildingCnt();
				}
			}
			
			//적 장애물들의 재생성
			if(Obstacle.transform.parent.name == "01_EnemyList")
			{
				if(GameStatus.chkDmg() == false)
				{
					StartCoroutine(fRegenEnemy());
					StartCoroutine(fRegenEnemy());
					
				} 
				else if(GameStatus.chkEnemyCnt() == 1)
				{
					StartCoroutine(fRegenEnemy());
					GameStatus.regenStart();
				}
				GameStatus.minusEnemyCnt();
			}
			
			Destroy(Obstacle.gameObject);
		}
	}
	
	//*************************
	//*****건물 생성 규칙*******
	//*************************
	void fGenBuilding()
	{
		//건물 장애물 생성
		genBuildingType = Random.Range(0, 3);
		Instantiate(ObstacleBuilding[genBuildingType]);
		if(genBuildingType == 2)
		{
			GameStatus.plusCloudCnt();
		}
		else
		{
			GameStatus.plusBuildingCnt();
		}
	}
	
	//***********************
	//****건물 재생성 규칙****
	//***********************
	IEnumerator fRegenBuilding()
	{
		//건물 장애물 재생성 규칙
		float delayTemp = Random.Range(regenMinDelayBuilding,regenMaxDelayBuilding);		
		yield return new WaitForSeconds(delayTemp);
		fGenBuilding();
	}
	
	//*************************
	//*******적 생성 규칙*******
	//*************************
	void fGenEnemy()
	{
		//적 장애물 생성
		genEnemyType = Random.Range(0, 3);
		Instantiate(ObstacleEnemy[genEnemyType]);
		GameStatus.plusEnemyCnt();
	}
	
	//***********************
	//*****적 재생성 규칙*****
	//***********************
	IEnumerator fRegenEnemy()
	{
		//적 장애물 재생성 규칙
		float delayTemp = Random.Range(regenMinDelayEnemy,regenMaxDelayEnemy);		
		yield return new WaitForSeconds(delayTemp);
		fGenEnemy();
	}
}
