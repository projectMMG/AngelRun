using UnityEngine;
using System.Collections;

public class TimeSum : MonoBehaviour {
	float sumTime = 0;
	float pointSec = 0;
	
	// Update is called once per frame
	void Update () {
	
		if(GameStatus.chkGameOver() == false)
		{
			pointSec += Time.deltaTime;
			
			if(pointSec >= 0.1f)
			{
				sumTime += pointSec;
                GetComponent<GUIText>().text = "Time : " + sumTime.ToString("#0.0");
				//				+ "\nEnemy : " + GameStatus.chkEnemyCnt()
				//				+ "\nBuilding : " + GameStatus.chkBuildingCnt()
				//				+ "\nCloud : " + GameStatus.chkCloudCnt();
				pointSec = 0;
			}
		}
		else
		{
			if(sumTime != 0)
			{
				int tempScore = (int)(sumTime * 100);
				GameStatus.bufInPreScore(tempScore);
			}
			sumTime = 0;
		}
		
		if(Application.platform == RuntimePlatform.Android)
		{
			if(Input.GetKey(KeyCode.Escape))
			{
				Application.Quit();
			}
		}
		
	}
}
