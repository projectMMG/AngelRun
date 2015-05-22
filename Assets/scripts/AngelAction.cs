using UnityEngine;
using System.Collections;

public class AngelAction : MonoBehaviour {
	public float angelGravity = 0;
	public float velotest = 0;
	//float ScrWidthRatio;
	//float ScrHeightRatio;
	bool dmgTaken = false;
	float dmgTime = 0;
	Animator animator;
	
	void init()
	{
		animator.SetBool("isCrying",false);
		transform.position = new Vector2(41.2f, 31.0f);
	}
	
	// Use this for initialization
	void Start () {
		//this.ScrWidthRatio = Screen.width/1280.0f;
		//this.ScrHeightRatio = Screen.height/720.0f;
		
		//초기설정
		animator = gameObject.GetComponent <Animator>();
		init ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//Input Check
		if(GameStatus.chkGameOver() == false &&
		   GameStatus.chkGameStart() == true)
		{
			animator.SetBool("isCrying",false);
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
				animator.SetBool("isFall",true);
				if(dmgTime >= 1.0f)
				{
					dmgTaken = false;
					animator.SetBool("isFall",false);
					dmgTime = 0.0f;
				}
				else
				{
					dmgTime += Time.deltaTime;
				}
			}
		}
		else if(GameStatus.chkGameOver() == true)
		{
			rigidbody2D.gravityScale = 0;
			if(GameStatus.chkGameOver() == true)
			{
				animator.SetBool("isCrying",false);
			}
			
			if(GameStatus.chkGameStart() == false)
			{
				animator.SetBool("isFall",false);
				animator.SetBool("isCrying",true);
				
				if(transform.position.x < 41.2f)
				{
					rigidbody2D.velocity = new Vector2(40,0);
				}
				else
				{
					velocityStop();
				}
				
				if(transform.position.y < 30.5f ||
				   transform.position.y > 31.5f)
				{
					transform.position = new Vector2(transform.position.x, 31.0f);
				}
				
				if(GameStatus.cntAllObstacle() == 0)
				{
					GameObject restartCall = GameObject.Find("01_GameObj");
					restartCall.transform.FindChild("Obstacle").gameObject.SetActive(false);
					
					restartCall = GameObject.Find("03_SystemUI");
					restartCall.transform.FindChild("gameOverSet").gameObject.SetActive(true);
				}
			}
			
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D Obstacle){
		if(GameStatus.chkGameOver() == false &&
		   Obstacle.tag != "Cloud" && dmgTaken == false)
		{
			dmgTaken = true;
			transform.position = new Vector2(transform.position.x - 12.8f, transform.position.y);
			
			GameStatus.regenStop();
		}
	}
	
	void velocityStop(){
		rigidbody2D.velocity = new Vector2(0,0);
	}
}

