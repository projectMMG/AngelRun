using UnityEngine;
using System.Collections;

public class ObstacleBuildingAction : MonoBehaviour {
	public float generateTime;
	public GameObject[] ObstacleBuilding = new GameObject[3];
	float timeTemp;
	int genBuildingType;
	bool randSet = false;

	// Use this for initialization
	void Start () {
		//초기설정		
	
	}
	
	// Update is called once per frame
	void Update () {
		if(randSet == false)
		{
			//generateDelay = Random.Range(0.0f,1.0f);
			genBuildingType = Random.Range(0,2+1);
			randSet = true;
		}
		
		timeTemp += Time.deltaTime;
		
		if(generateTime < timeTemp)
		{
			//생성
			Instantiate(ObstacleBuilding[genBuildingType]);
			timeTemp = 0;
			randSet = false;
		}
	}
	
	void OnTriggerEnter2D(Collider2D Obstacle){
		Destroy(Obstacle.gameObject);
	}
	
}
