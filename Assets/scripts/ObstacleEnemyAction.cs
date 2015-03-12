using UnityEngine;
using System.Collections;

public class ObstacleEnemyAction : MonoBehaviour {
	float testY;
	float testSpeed;

	// Use this for initialization
	void Start () {
		//초기설정
		testY = Random.Range(7.0f,60.0f);
		testSpeed = Random.Range(10.0f,100.0f);
		transform.position = new Vector2(128.0f,testY);
		rigidbody2D.velocity = new Vector2(-testSpeed,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < 0.0f)
		{
			Destroy(gameObject);
		}
	
	}
}
