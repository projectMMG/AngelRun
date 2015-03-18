using UnityEngine;
using System.Collections;

public class ObstacleBuildingAction : MonoBehaviour {
	public float scrlSpeed;

	// Use this for initialization
	void Start () {
		//초기설정
		transform.position = new Vector2(128.0f,5.1f);
		rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < 0.0f)
		{
			Destroy(gameObject);
		}
	}
}
