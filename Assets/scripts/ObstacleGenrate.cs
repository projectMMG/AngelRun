using UnityEngine;
using System.Collections;

public class ObstacleGenrate : MonoBehaviour {
	public GameObject[] ObstacleBuilding = new GameObject[2];
	public GameObject[] ObstacleEnemy = new GameObject[3];
	float genBuildingTime, genEnemyTime;
	int genBuildingType, genEnemyType;
	bool randSet = false;
	//string[] buildingList = new string[2];
	//string[] enemyList = new string[3];

	// Use this for initialization
	void Start () {
		//buildingList.SetValue("house01",0);
		//buildingList.SetValue("building01",1);
		//enemyList.SetValue("helicop01",0);
		//enemyList.SetValue("plane01",1);
		//enemyList.SetValue("tank01",2);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(randSet == false)
		{
			genBuildingTime = Random.Range(0.0f,2.0f);
			genBuildingType = Random.Range(0,1+1);
			//ObstacleBuilding = GameObject.Find(buildingList[genBuildingType]);
			
			genEnemyTime = Random.Range(0.0f,2.0f);
			genEnemyType = Random.Range(0,2+1);
			//ObstacleEnemy = GameObject.Find(enemyList[genEnemyType]);
			randSet = true;
		}
		
		genBuildingTime -= Time.deltaTime;
		genEnemyTime -= Time.deltaTime;
		
		if(genBuildingTime <= 0)
		{
			Instantiate(ObstacleBuilding[genBuildingType]);
			randSet = false;
		}
		
		if(genEnemyTime <= 0)
		{
			Instantiate(ObstacleEnemy[genEnemyType]);
			randSet = false;
		}
	
	}
}
