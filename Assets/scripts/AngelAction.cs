using UnityEngine;
using System.Collections;

public class AngelAction : MonoBehaviour {
	public float angelGravity = 0;
	public float velotest = 0;
	//float ScrWidthRatio;
	//float ScrHeightRatio;
	bool dmgTaken = false;
	float dmgTime = 0;

	// Use this for initialization
	void Start () {
		//this.ScrWidthRatio = Screen.width/1280.0f;
		//this.ScrHeightRatio = Screen.height/720.0f;
		
		//초기설정
		transform.position = new Vector2(51.2f, 36.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//Input Check
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if(rigidbody2D.velocity.y < 0)
			{
				velocityStop();
			}
			rigidbody2D.gravityScale = -angelGravity;
		}
		else
		{
			rigidbody2D.gravityScale = angelGravity;
		}
		velotest = rigidbody2D.velocity.y;
		
		//Damage Check
		if(dmgTaken == true)
		{
			if(dmgTime >= 1.0f)
			{
				Debug.Log(dmgTime + " / dmgTaken = False");
				dmgTaken = false;
				dmgTime = 0.0f;
			}
			else
			{
				dmgTime += Time.deltaTime;
			}
		}
			
	}
	
	void OnTriggerEnter2D(Collider2D Obstacle){
		if(dmgTaken == false)
		{
			Debug.Log ("dmgTaken = True");
			dmgTaken = true;
			transform.position = new Vector2(transform.position.x - 12.8f, transform.position.y);
		}
	}
	
	void velocityStop(){
		rigidbody2D.velocity = new Vector2(0,0);
	}
}

