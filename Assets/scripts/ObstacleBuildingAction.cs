using UnityEngine;
using System.Collections;

public class ObstacleBuildingAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//초기설정
		transform.position = new Vector2(128.0f,5.1f);
		rigidbody2D.velocity = new Vector2(-60.0f,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < 0.0f)
		{
			Destroy(gameObject);
		}
	}
}
