using UnityEngine;
using System.Collections;

public class BuildingAction : MonoBehaviour {
	public float scrlSpeed;

	// Use this for initialization
	void Start () {
		//초기설정
		transform.position = new Vector2(128.0f,5.1f);
		rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
	
	}
	
	void OnTriggerEnter2D(Collider2D Obstacle){
		Destroy(Obstacle.gameObject);
	}
}
