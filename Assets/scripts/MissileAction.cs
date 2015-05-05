using UnityEngine;
using System.Collections;

public class MissileAction : MonoBehaviour {
	public float scrlSpeed;
	
	
	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("03_Bullet").transform;
		//randPos = Random.Range(posMin, posMax); //randPos = Random.Range(5.1f, 46.0f);
		//transform.position = new Vector2(128.0f,50.0f);
		//rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
		
	}
	
	//활성화
	void OnEnable()
	{
		lunchMissile();
	}
	
	public void lunchMissile()
	{
		rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
	}
}
