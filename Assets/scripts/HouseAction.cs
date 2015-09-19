using UnityEngine;
using System.Collections;

public class HouseAction : MonoBehaviour {
	public float scrlSpeed;

	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("02_BuildingList").transform;
		transform.position = new Vector2(128.0f,5.0f);
		GetComponent<Rigidbody2D>().velocity = new Vector2(-scrlSpeed,0);
	
	}
	
}
