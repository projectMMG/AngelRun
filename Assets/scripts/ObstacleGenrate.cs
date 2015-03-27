using UnityEngine;
using System.Collections;

public class ObstacleGenrate : MonoBehaviour {
	public GameObject[] ObstacleBuilding = new GameObject[2];
	public GameObject[] ObstacleEnemy = new GameObject[3];
	float genBuildingTime, genEnemyTime;
	int genBuildingType, genEnemyType;
	bool randSet = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(randSet == false)
		{
			genBuildingTime = Random.Range(0.0f,2.0f);
			genBuildingType = Random.Range(0,1+1);
			
			genEnemyTime = Random.Range(0.0f,2.0f);
			genEnemyType = Random.Range(0,2+1);
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
