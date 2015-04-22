using UnityEngine;
using System.Collections;

public class ObstacleGenrate : MonoBehaviour {
	public GameObject[] ObstacleBuilding = new GameObject[2];
	public GameObject[] ObstacleEnemy = new GameObject[3];
	public float genBuildingTime, startBuildingTime;
	
	float delayTemp = 0;
	int genBuildingType, genEnemyType;
	bool randSet = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating("fGenBuilding",startBuildingTime,genBuildingTime);
	}
	
	// Update is called once per frame
	/*
	void Update () {
		if(randSet == false)
		{
			//genBuildingTime = Random.Range(0.0f,2.0f);
			genBuildingType = Random.Range(0,1+1);
			
			//genEnemyTime = Random.Range(0.0f,2.0f);
			//genEnemyType = Random.Range(0,2+1);
			randSet = true;
		}
		
		timetemp += Time.deltaTime;
		
		if(genBuildingTime <= timetemp)
		{
			Instantiate(ObstacleBuilding[genBuildingType]);
			randSet = false;
			timetemp = 0;
		}
		
		
		if(genEnemyTime <= 0)
		{
			Instantiate(ObstacleEnemy[genEnemyType]);
			randSet = false;
		}
		
	
	}
	*/
	
	void OnTriggerEnter2D(Collider2D Obstacle){
		Destroy(Obstacle.gameObject);
		
		//건물 장애물들의 재생성
		StartCoroutine(fRegenBuilding());
		
		//적 장애물들의 재생성
	}
	
	void fGenBuilding()
	{
		//건물 장애물 생성
		genBuildingType = Random.Range(0, 3);
		GameObject BuildObj = (GameObject)Object.Instantiate(ObstacleBuilding[genBuildingType]);
				
		//차일드화
	}
	
	IEnumerator fRegenBuilding()
	{
		//건물 장애물 재생성 규칙
		delayTemp = Random.Range(0.0f,1.1f);		
		yield return new WaitForSeconds(delayTemp);
		fGenBuilding();
	}
}
