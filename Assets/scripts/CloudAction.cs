using UnityEngine;
using System.Collections;

public class CloudAction : MonoBehaviour {
	public float scrlSpeed;
	public float posMin, posMax;
	float randPos;
	
	// Use this for initialization
	void Start () {
		transform.parent = GameObject.Find("00_Cloud").transform;
		randPos = Random.Range(posMin, posMax);
		transform.position = new Vector3(128.0f,randPos,-10);
		GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpeed,0);
		
	}
	
}
