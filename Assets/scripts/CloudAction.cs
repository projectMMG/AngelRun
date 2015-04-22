using UnityEngine;
using System.Collections;

public class CloudAction : MonoBehaviour {
	public float scrlSpeed;
	float randPos;
	
	// Use this for initialization
	void Start () {
		transform.parent = GameObject.Find("00_Cloud").transform;
		randPos = Random.Range(5.1f, 46.0f);
		transform.position = new Vector3(128.0f,randPos,-10);
		rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
		
	}
	
}
