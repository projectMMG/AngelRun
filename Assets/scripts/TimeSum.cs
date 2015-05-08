using UnityEngine;
using System.Collections;

public class TimeSum : MonoBehaviour {
	float sumTime = 0;
	float pointSec = 0;
	
	// Update is called once per frame
	void Update () {
		pointSec += Time.deltaTime;
		
		if(pointSec >= 0.1f)
		{
			sumTime += pointSec;
			guiText.text = sumTime.ToString("#.0");
			pointSec = 0;
		}
	}
}
